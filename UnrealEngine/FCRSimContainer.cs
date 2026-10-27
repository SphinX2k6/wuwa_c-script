using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004DA RID: 1242
	[UnrealObjectPath("/Script/ControlRig.CRSimContainer")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCRSimContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004291 RID: 17041 RVA: 0x00063727 File Offset: 0x00061927
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRSimContainer._ScriptStructPtr != 0) ? FCRSimContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRSimContainer", ref FCRSimContainer._ScriptStructPtr);
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x0006374B File Offset: 0x0006194B
		// (set) Token: 0x06004293 RID: 17043 RVA: 0x0006375B File Offset: 0x0006195B
		public unsafe float TimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimContainer.__PropertyOffset_TimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimContainer.__PropertyOffset_TimeStep) = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x0006376C File Offset: 0x0006196C
		// (set) Token: 0x06004295 RID: 17045 RVA: 0x0006377C File Offset: 0x0006197C
		public unsafe float AccumulatedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimContainer.__PropertyOffset_AccumulatedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimContainer.__PropertyOffset_AccumulatedTime) = value;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x0006378D File Offset: 0x0006198D
		// (set) Token: 0x06004297 RID: 17047 RVA: 0x0006379D File Offset: 0x0006199D
		public unsafe float TimeLeftForStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimContainer.__PropertyOffset_TimeLeftForStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimContainer.__PropertyOffset_TimeLeftForStep) = value;
			}
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x000637AE File Offset: 0x000619AE
		public FCRSimContainer()
		{
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x000637B6 File Offset: 0x000619B6
		public FCRSimContainer(float TimeStep, float AccumulatedTime, float TimeLeftForStep)
		{
			this.TimeStep = TimeStep;
			this.AccumulatedTime = AccumulatedTime;
			this.TimeLeftForStep = TimeLeftForStep;
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x000637D3 File Offset: 0x000619D3
		protected override IntPtr GetUStructPtr()
		{
			return FCRSimContainer.StaticStruct();
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x000637DF File Offset: 0x000619DF
		[NullableContext(2)]
		public FCRSimContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x000637E9 File Offset: 0x000619E9
		public FCRSimContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x000637F4 File Offset: 0x000619F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRSimContainer(Pointer, false, true);
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x000637FE File Offset: 0x000619FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRSimContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04001FA2 RID: 8098
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.CRSimContainer";

		// Token: 0x04001FA3 RID: 8099
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FA4 RID: 8100
		internal static int __PropertyOffset_TimeStep;

		// Token: 0x04001FA5 RID: 8101
		internal static int __PropertyOffset_AccumulatedTime;

		// Token: 0x04001FA6 RID: 8102
		internal static int __PropertyOffset_TimeLeftForStep;
	}
}
