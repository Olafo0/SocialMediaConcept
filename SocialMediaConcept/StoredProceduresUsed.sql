CREATE PROCEDURE [dbo].[InsertNewUser] @Username varchar(30), @DisplayName varchar(50), @Password varchar(50), @Email varchar(100)
AS 
INSERT INTO tbl_users(Username,DisplayName,Password_,Email)
VALUES(@Username,@DisplayName,@Password,@Email)

CREATE PROCEDURE [dbo].[LikeChecker] @GivenUserID int, @GivenPostID int
AS
SELECT * FROM LikedPosts WHERE PostID = @GivenPostID AND UserID = @GivenUserID;

CREATE PROCEDURE [dbo].[LoginChecker] @Username varchar(30), @Password varchar(50)
AS 
SELECT Username, Password_ FROM tbl_users WHERE Username = @Username and Password_ = @Password

CREATE PROCEDURE [dbo].[PostIDReturn] @GivenUserID int, @GivenPostPicture varbinary(max), @GivenPostTItle varchar(80), @GivenDatePosted DateTime
AS 
SELECT PostID FROM tbl_Posts WHERE UserID = @GivenUserID AND PostPicture = @GivenPostPicture AND PostTitle = @GivenPostTitle AND DatePosted = @GivenDatePosted

CREATE PROCEDURE [dbo].[PostLiked] @GivenPostID int, @GivenUserID int
AS 
UPDATE tbl_Posts
SET Likes = Likes + 1
WHERE PostID = @GivenPostID

INSERT INTO LikedPosts(PostID,UserID)
VALUES(@GivenPostID,@GivenUserID)

CREATE PROCEDURE [dbo].[ReadPosts]
AS
SELECT * FROM tbl_Posts

CREATE PROCEDURE [dbo].[RefreshedTimeLine] @DateGiven DateTime
AS 
SELECT * FROM tbl_Posts WHERE DatePosted > @DateGiven

CREATE PROCEDURE [dbo].[SettingUserUp] @LoggedUsername varchar(30)
AS 
SELECT * FROM tbl_users WHERE Username = @LoggedUsername;

CREATE PROCEDURE [dbo].[UploadPost] @userID int, @postPicture varbinary(max), @postTitle varchar(80), @descripition varchar(150), @likes int, @datePosted datetime
AS 
INSERT INTO tbl_Posts(UserID,PostPicture,PostTitle,Description_,Likes,DatePosted)
VALUES(@userID, @postPicture, @postTitle, @descripition, @likes, @datePosted)

