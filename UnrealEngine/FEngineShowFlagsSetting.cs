using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000AF5 RID: 2805
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EngineShowFlagsSetting")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FEngineShowFlagsSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600926E RID: 37486 RVA: 0x000D21A5 File Offset: 0x000D03A5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineShowFlagsSetting._ScriptStructPtr != 0) ? FEngineShowFlagsSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EngineShowFlagsSetting", ref FEngineShowFlagsSetting._ScriptStructPtr);
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x0600926F RID: 37487 RVA: 0x000D21C9 File Offset: 0x000D03C9
		// (set) Token: 0x06009270 RID: 37488 RVA: 0x000D21DD File Offset: 0x000D03DD
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

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x000D21F2 File Offset: 0x000D03F2
		// (set) Token: 0x06009272 RID: 37490 RVA: 0x000D2202 File Offset: 0x000D0402
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

		// Token: 0x06009273 RID: 37491 RVA: 0x000D2213 File Offset: 0x000D0413
		public FEngineShowFlagsSetting()
		{
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x000D221B File Offset: 0x000D041B
		public FEngineShowFlagsSetting(string ShowFlagName, bool Enabled)
		{
			this.ShowFlagName = ShowFlagName;
			this.Enabled = Enabled;
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x000D2231 File Offset: 0x000D0431
		protected override IntPtr GetUStructPtr()
		{
			return FEngineShowFlagsSetting.StaticStruct();
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x000D223D File Offset: 0x000D043D
		[NullableContext(2)]
		public FEngineShowFlagsSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x000D2247 File Offset: 0x000D0447
		public FEngineShowFlagsSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x000D2252 File Offset: 0x000D0452
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineShowFlagsSetting(Pointer, false, true);
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x000D225C File Offset: 0x000D045C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineShowFlagsSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04004CE2 RID: 19682
		public const string __ObjectPath = "/Script/Engine.EngineShowFlagsSetting";

		// Token: 0x04004CE3 RID: 19683
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004CE4 RID: 19684
		internal static int __PropertyOffset_ShowFlagName;

		// Token: 0x04004CE5 RID: 19685
		internal static int __PropertyOffset_Enabled;
	}
}
