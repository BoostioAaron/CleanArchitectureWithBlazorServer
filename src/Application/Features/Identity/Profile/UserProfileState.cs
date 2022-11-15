﻿
using BlazorState;
namespace CleanArchitecture.Blazor.Application.Features.Identity.Profile;


public partial class UserProfileState : State<UserProfileState>
{
    public UserProfile UserProfile { get; private set; }
    public override void Initialize()=> UserProfile=new();
}
