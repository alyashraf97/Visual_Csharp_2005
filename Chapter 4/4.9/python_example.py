class GradeBook():
    def __init__(self):
        self.courseName = ""
    
    def display_message(self):
        print(self.courseName)
        

gradeBook = GradeBook()
gradeBook.courseName="CS101"
gradeBook.display_message()