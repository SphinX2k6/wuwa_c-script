using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E1 RID: 1761
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Timeline")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_Timeline : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E70 RID: 24176 RVA: 0x000877D2 File Offset: 0x000859D2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Timeline._ScriptStructPtr != 0) ? FRigUnit_Timeline._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Timeline", ref FRigUnit_Timeline._ScriptStructPtr);
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x000877F6 File Offset: 0x000859F6
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x00087806 File Offset: 0x00085A06
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Timeline.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Timeline.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x00087817 File Offset: 0x00085A17
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x00087827 File Offset: 0x00085A27
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Timeline.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Timeline.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x00087838 File Offset: 0x00085A38
		// (set) Token: 0x06005E76 RID: 24182 RVA: 0x00087848 File Offset: 0x00085A48
		public unsafe float AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Timeline.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Timeline.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x00087859 File Offset: 0x00085A59
		public FRigUnit_Timeline()
		{
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x00087861 File Offset: 0x00085A61
		public FRigUnit_Timeline(float Speed, float Time, float AccumulatedValue)
		{
			this.Speed = Speed;
			this.Time = Time;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x0008787E File Offset: 0x00085A7E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Timeline.StaticStruct();
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x0008788A File Offset: 0x00085A8A
		[NullableContext(2)]
		public FRigUnit_Timeline(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x00087894 File Offset: 0x00085A94
		public FRigUnit_Timeline(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x0008789F File Offset: 0x00085A9F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Timeline(Pointer, false, true);
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x000878A9 File Offset: 0x00085AA9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Timeline(Pointer, MemoryOwner);
		}

		// Token: 0x04002C2B RID: 11307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Timeline";

		// Token: 0x04002C2C RID: 11308
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C2D RID: 11309
		internal static int __PropertyOffset_Speed;

		// Token: 0x04002C2E RID: 11310
		internal static int __PropertyOffset_Time;

		// Token: 0x04002C2F RID: 11311
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
