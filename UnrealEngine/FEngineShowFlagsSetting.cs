using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001EE RID: 494
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EngineShowFlagsSetting")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FEngineShowFlagsSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600219A RID: 8602 RVA: 0x00031462 File Offset: 0x0002F662
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineShowFlagsSetting._ScriptStructPtr != 0) ? FEngineShowFlagsSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EngineShowFlagsSetting", ref FEngineShowFlagsSetting._ScriptStructPtr);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x00031486 File Offset: 0x0002F686
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x0003149A File Offset: 0x0002F69A
		public unsafe string ShowFlagName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineShowFlagsSetting.__PropertyOffset_ShowFlagName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineShowFlagsSetting.__PropertyOffset_ShowFlagName)), value);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x000314AF File Offset: 0x0002F6AF
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x000314BF File Offset: 0x0002F6BF
		public unsafe bool Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEngineShowFlagsSetting.__PropertyOffset_Enabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEngineShowFlagsSetting.__PropertyOffset_Enabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000314D0 File Offset: 0x0002F6D0
		public FEngineShowFlagsSetting()
		{
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000314D8 File Offset: 0x0002F6D8
		protected override IntPtr GetUStructPtr()
		{
			return FEngineShowFlagsSetting.StaticStruct();
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000314E4 File Offset: 0x0002F6E4
		[NullableContext(2)]
		public FEngineShowFlagsSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x000314EE File Offset: 0x0002F6EE
		public FEngineShowFlagsSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x000314F9 File Offset: 0x0002F6F9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineShowFlagsSetting(Pointer, false, true);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00031503 File Offset: 0x0002F703
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineShowFlagsSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04000C37 RID: 3127
		public const string __ObjectPath = "/Script/Engine.EngineShowFlagsSetting";

		// Token: 0x04000C38 RID: 3128
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C39 RID: 3129
		internal static int __PropertyOffset_ShowFlagName;

		// Token: 0x04000C3A RID: 3130
		internal static int __PropertyOffset_Enabled;
	}
}
