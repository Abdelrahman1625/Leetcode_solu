# Write your MySQL query statement below
Select tweet_id 
From Tweets
where Length(content) > 15
order by tweet_id ASC;