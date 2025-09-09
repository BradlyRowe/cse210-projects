using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
		"What habits or routines help me feel most grounded and focused?",
		"What's one fear I've outgrown, and what helped me move past it?",
		"How do I define “growth” in my life right now—technically, creatively, personally?",
		"What's a recent moment I felt proud of, and why?",
		"What does my inner critic sound like—and how do I respond to it?",
		"What's something I've learned the hard way, and how has it shaped me?",
		"How do I recharge when I feel mentally or emotionally drained?",
		"What's one value I refuse to compromise on, even under pressure?",
		"What's a skill I've honed over the years that I now take for granted?",
		"When do I feel most like myself—and what contributes to that feeling?",
		"What's a past version of me that I've outgrown, and what would I say to them?",
		"What does “balance” mean to me, and how do I maintain it?",
		"What's a recurring challenge I face, and what patterns do I notice around it?",
		"How do I handle feedback—both constructive and critical?",
		"What's a personal boundary I've recently reinforced, and how did it feel?",
		"What role does creativity play in my growth journey?",
		"What's one thing I've been procrastinating, and what's really behind the delay?",
		"How do I measure progress in areas that aren't easily quantifiable?",
		"What's a lesson I keep relearning, and what does that say about me?",
		"What kind of legacy or impact do I want to leave behind—technically, artistically, or personally?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}