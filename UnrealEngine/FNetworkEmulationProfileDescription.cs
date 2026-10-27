using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EEB RID: 3819
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NetworkEmulationProfileDescription")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNetworkEmulationProfileDescription : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF1E RID: 53022 RVA: 0x0012E2FD File Offset: 0x0012C4FD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNetworkEmulationProfileDescription._ScriptStructPtr != 0) ? FNetworkEmulationProfileDescription._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NetworkEmulationProfileDescription", ref FNetworkEmulationProfileDescription._ScriptStructPtr);
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0600CF1F RID: 53023 RVA: 0x0012E321 File Offset: 0x0012C521
		// (set) Token: 0x0600CF20 RID: 53024 RVA: 0x0012E335 File Offset: 0x0012C535
		public unsafe string ProfileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNetworkEmulationProfileDescription.__PropertyOffset_ProfileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNetworkEmulationProfileDescription.__PropertyOffset_ProfileName)), value);
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0600CF21 RID: 53025 RVA: 0x0012E34A File Offset: 0x0012C54A
		// (set) Token: 0x0600CF22 RID: 53026 RVA: 0x0012E35E File Offset: 0x0012C55E
		public unsafe string ToolTip
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNetworkEmulationProfileDescription.__PropertyOffset_ToolTip)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNetworkEmulationProfileDescription.__PropertyOffset_ToolTip)), value);
			}
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x0012E373 File Offset: 0x0012C573
		public FNetworkEmulationProfileDescription()
		{
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x0012E37B File Offset: 0x0012C57B
		public FNetworkEmulationProfileDescription(string ProfileName, string ToolTip)
		{
			this.ProfileName = ProfileName;
			this.ToolTip = ToolTip;
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x0012E391 File Offset: 0x0012C591
		protected override IntPtr GetUStructPtr()
		{
			return FNetworkEmulationProfileDescription.StaticStruct();
		}

		// Token: 0x0600CF26 RID: 53030 RVA: 0x0012E39D File Offset: 0x0012C59D
		[NullableContext(2)]
		public FNetworkEmulationProfileDescription(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF27 RID: 53031 RVA: 0x0012E3A7 File Offset: 0x0012C5A7
		public FNetworkEmulationProfileDescription(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF28 RID: 53032 RVA: 0x0012E3B2 File Offset: 0x0012C5B2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNetworkEmulationProfileDescription(Pointer, false, true);
		}

		// Token: 0x0600CF29 RID: 53033 RVA: 0x0012E3BC File Offset: 0x0012C5BC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNetworkEmulationProfileDescription(Pointer, MemoryOwner);
		}

		// Token: 0x04006FB3 RID: 28595
		public const string __ObjectPath = "/Script/Engine.NetworkEmulationProfileDescription";

		// Token: 0x04006FB4 RID: 28596
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006FB5 RID: 28597
		internal static int __PropertyOffset_ProfileName;

		// Token: 0x04006FB6 RID: 28598
		internal static int __PropertyOffset_ToolTip;
	}
}
