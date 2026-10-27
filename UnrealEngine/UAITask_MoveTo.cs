using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000117 RID: 279
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AITask_MoveTo")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAITask_MoveTo : UAITask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001490 RID: 5264 RVA: 0x0001E472 File Offset: 0x0001C672
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAITask_MoveTo._ClassPtr;
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0001E480 File Offset: 0x0001C680
		public UAITask_MoveTo() : this(BuiltinUtils.AllocNativeUObject(UAITask_MoveTo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		public UAITask_MoveTo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAITask_MoveTo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0001E4DC File Offset: 0x0001C6DC
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0001E515 File Offset: 0x0001C715
		public FGenericGameplayTaskDelegate OnRequestFailed
		{
			get
			{
				base.FastCheckIsValid();
				FGenericGameplayTaskDelegate result;
				if ((result = this._OnRequestFailed) == null)
				{
					result = (this._OnRequestFailed = new FGenericGameplayTaskDelegate(base.NativePtr + (IntPtr)UAITask_MoveTo.__PropertyOffset_OnRequestFailed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAITask_MoveTo.__PropertyOffset_OnRequestFailed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0001E538 File Offset: 0x0001C738
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0001E571 File Offset: 0x0001C771
		public FMoveTaskCompletedSignature OnMoveFinished
		{
			get
			{
				base.FastCheckIsValid();
				FMoveTaskCompletedSignature result;
				if ((result = this._OnMoveFinished) == null)
				{
					result = (this._OnMoveFinished = new FMoveTaskCompletedSignature(base.NativePtr + (IntPtr)UAITask_MoveTo.__PropertyOffset_OnMoveFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAITask_MoveTo.__PropertyOffset_OnMoveFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0001E594 File Offset: 0x0001C794
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0001E5CD File Offset: 0x0001C7CD
		public FAIMoveRequest MoveRequest
		{
			get
			{
				base.FastCheckIsValid();
				FAIMoveRequest result;
				if ((result = this._MoveRequest) == null)
				{
					result = (this._MoveRequest = new FAIMoveRequest(base.NativePtr + (IntPtr)UAITask_MoveTo.__PropertyOffset_MoveRequest, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIMoveRequest.StaticStruct(), base.NativePtr + (IntPtr)UAITask_MoveTo.__PropertyOffset_MoveRequest, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0001E5F0 File Offset: 0x0001C7F0
		[NullableContext(2)]
		public static UAITask_MoveTo AIMoveTo(AAIController Controller, FVector GoalLocation, AActor GoalActor = null, float AcceptanceRadius = -1f, EAIOptionFlag StopOnOverlap = EAIOptionFlag.Default, EAIOptionFlag AcceptPartialPath = EAIOptionFlag.Default, bool bUsePathfinding = true, bool bLockAILogic = true, bool bUseContinuosGoalTracking = false, EAIOptionFlag ProjectGoalOnNavigation = EAIOptionFlag.Default)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAITask_MoveTo>(UAITask_MoveTo.__AIMoveTo_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, GoalLocation, (GoalActor != null) ? GoalActor.NativePtr : IntPtr.Zero, AcceptanceRadius, StopOnOverlap, AcceptPartialPath, bUsePathfinding, bLockAILogic, bUseContinuosGoalTracking, ProjectGoalOnNavigation));
		}

		// Token: 0x0600149A RID: 5274
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AIMoveTo_Internal(IntPtr Controller, FVector GoalLocation, IntPtr GoalActor, float AcceptanceRadius, TEnumAsByte<EAIOptionFlag> StopOnOverlap, TEnumAsByte<EAIOptionFlag> AcceptPartialPath, bool bUsePathfinding, bool bLockAILogic, bool bUseContinuosGoalTracking, TEnumAsByte<EAIOptionFlag> ProjectGoalOnNavigation);

		// Token: 0x0600149B RID: 5275 RVA: 0x0001E644 File Offset: 0x0001C844
		static UAITask_MoveTo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AITask_MoveTo");
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0001E652 File Offset: 0x0001C852
		protected UAITask_MoveTo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400042B RID: 1067
		public new const string __ObjectPath = "/Script/AIModule.AITask_MoveTo";

		// Token: 0x0400042C RID: 1068
		private static IntPtr _ClassPtr;

		// Token: 0x0400042D RID: 1069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400042E RID: 1070
		internal static int __PropertyOffset_OnRequestFailed;

		// Token: 0x0400042F RID: 1071
		[Nullable(2)]
		private FGenericGameplayTaskDelegate _OnRequestFailed;

		// Token: 0x04000430 RID: 1072
		internal static int __PropertyOffset_OnMoveFinished;

		// Token: 0x04000431 RID: 1073
		[Nullable(2)]
		private FMoveTaskCompletedSignature _OnMoveFinished;

		// Token: 0x04000432 RID: 1074
		internal static int __PropertyOffset_MoveRequest;

		// Token: 0x04000433 RID: 1075
		[Nullable(2)]
		private FAIMoveRequest _MoveRequest;
	}
}
