from flask import Flask, request, jsonify
from flask_sqlalchemy import SQLAlchemy
from datetime import datetime

app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///notes.db'
db = SQLAlchemy(app)

class Note(db.Model):
id = db.Column(db.Integer, primary_key=True)
title = db.Column(db.String(100), nullable=False)
content = db.Column(db.Text, nullable=False)
created_at = db.Column(db.DateTime, default=datetime.utcnow)
updated_at = db.Column(db.DateTime, default=datetime.utcnow, onupdate=datetime.utcnow)

@app.route('/notes', methods=['GET'])
def get_notes():
notes = Note.query.all()
output = []
for note in notes:
note_data = {
'id': note.id,
'title': note.title,
'content': note.content,
'created_at': note.created_at,
'updated_at': note.updated_at
}
output.append(note_data)
return jsonify({'notes': output})

@app.route('/notes/<int:note_id>', methods=['GET'])
def get_note(note_id):
note = Note.query.get_or_404(note_id)
note_data = {
'id': note.id,
'title': note.title,
'content': note.content,
'created_at': note.created_at,
'updated_at': note.updated_at
}
return jsonify(note_data)

@app.route('/notes', methods=['POST'])
def create_note():
data = request.get_json()
new_note = Note(title=data['title'], content=data['content'])
db.session.add(new_note)
db.session.commit()
return jsonify({'message': 'Note created successfully'})

@app.route('/notes/<int:note_id>', methods=['PUT'])
def update_note(note_id):
note = Note.query.get_or_404(note_id)
data = request.get_json()
note.title = data['title']
note.content = data['content']
db.session.commit()
return jsonify({'message': 'Note updated successfully'})

@app.route('/notes/<int:note_id>', methods=['DELETE'])
def delete_note(note_id):
note = Note.query.get_or_404(note_id)
db.session.delete(note)
db.session.commit()
return jsonify({'message': 'Note deleted successfully'})

if __name__ == '__main__':
db.create_all()
app.run(debug=True)
