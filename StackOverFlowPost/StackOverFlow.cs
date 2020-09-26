using System;

namespace StackOverFlowPost
{
    class StackOverFlow
    {
        private  int _vote;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
        public void Up_vote()
        {
            this._vote++;
        }

        public void Down_vote()
        {
            this._vote--;
        }

        public int GetUp_vote
        {
            get 
            {
                return this._vote;
            }
        }
    }
}
