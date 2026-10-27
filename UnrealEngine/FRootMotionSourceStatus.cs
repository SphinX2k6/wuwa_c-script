using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010A2 RID: 4258
	[UnrealObjectPath("/Script/Engine.RootMotionSourceStatus")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FRootMotionSourceStatus : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F366 RID: 62310 RVA: 0x00168F9E File Offset: 0x0016719E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSourceStatus._ScriptStructPtr != 0) ? FRootMotionSourceStatus._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSourceStatus", ref FRootMotionSourceStatus._ScriptStructPtr);
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0600F367 RID: 62311 RVA: 0x00168FC2 File Offset: 0x001671C2
		// (set) Token: 0x0600F368 RID: 62312 RVA: 0x00168FD2 File Offset: 0x001671D2
		public unsafe byte Flags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSourceStatus.__PropertyOffset_Flags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSourceStatus.__PropertyOffset_Flags) = value;
			}
		}

		// Token: 0x0600F369 RID: 62313 RVA: 0x00168FE3 File Offset: 0x001671E3
		public FRootMotionSourceStatus()
		{
		}

		// Token: 0x0600F36A RID: 62314 RVA: 0x00168FEB File Offset: 0x001671EB
		public FRootMotionSourceStatus(byte Flags)
		{
			this.Flags = Flags;
		}

		// Token: 0x0600F36B RID: 62315 RVA: 0x00168FFA File Offset: 0x001671FA
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSourceStatus.StaticStruct();
		}

		// Token: 0x0600F36C RID: 62316 RVA: 0x00169006 File Offset: 0x00167206
		[NullableContext(2)]
		public FRootMotionSourceStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F36D RID: 62317 RVA: 0x00169010 File Offset: 0x00167210
		public FRootMotionSourceStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F36E RID: 62318 RVA: 0x0016901B File Offset: 0x0016721B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSourceStatus(Pointer, false, true);
		}

		// Token: 0x0600F36F RID: 62319 RVA: 0x00169025 File Offset: 0x00167225
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSourceStatus(Pointer, MemoryOwner);
		}

		// Token: 0x040083FD RID: 33789
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RootMotionSourceStatus";

		// Token: 0x040083FE RID: 33790
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083FF RID: 33791
		internal static int __PropertyOffset_Flags;
	}
}
