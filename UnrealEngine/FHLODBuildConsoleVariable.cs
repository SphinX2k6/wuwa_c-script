using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C27 RID: 3111
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODBuildConsoleVariable")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FHLODBuildConsoleVariable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009DE6 RID: 40422 RVA: 0x000E076E File Offset: 0x000DE96E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODBuildConsoleVariable._ScriptStructPtr != 0) ? FHLODBuildConsoleVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODBuildConsoleVariable", ref FHLODBuildConsoleVariable._ScriptStructPtr);
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x000E0792 File Offset: 0x000DE992
		// (set) Token: 0x06009DE8 RID: 40424 RVA: 0x000E07A6 File Offset: 0x000DE9A6
		public unsafe string VariableName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODBuildConsoleVariable.__PropertyOffset_VariableName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODBuildConsoleVariable.__PropertyOffset_VariableName)), value);
			}
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x06009DE9 RID: 40425 RVA: 0x000E07BB File Offset: 0x000DE9BB
		// (set) Token: 0x06009DEA RID: 40426 RVA: 0x000E07CF File Offset: 0x000DE9CF
		public unsafe string OverrideValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODBuildConsoleVariable.__PropertyOffset_OverrideValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODBuildConsoleVariable.__PropertyOffset_OverrideValue)), value);
			}
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x000E07E4 File Offset: 0x000DE9E4
		public FHLODBuildConsoleVariable()
		{
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x000E07EC File Offset: 0x000DE9EC
		public FHLODBuildConsoleVariable(string VariableName, string OverrideValue)
		{
			this.VariableName = VariableName;
			this.OverrideValue = OverrideValue;
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x000E0802 File Offset: 0x000DEA02
		protected override IntPtr GetUStructPtr()
		{
			return FHLODBuildConsoleVariable.StaticStruct();
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x000E080E File Offset: 0x000DEA0E
		[NullableContext(2)]
		public FHLODBuildConsoleVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x000E0818 File Offset: 0x000DEA18
		public FHLODBuildConsoleVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x000E0823 File Offset: 0x000DEA23
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODBuildConsoleVariable(Pointer, false, true);
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x000E082D File Offset: 0x000DEA2D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODBuildConsoleVariable(Pointer, MemoryOwner);
		}

		// Token: 0x04005713 RID: 22291
		public const string __ObjectPath = "/Script/Engine.HLODBuildConsoleVariable";

		// Token: 0x04005714 RID: 22292
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005715 RID: 22293
		internal static int __PropertyOffset_VariableName;

		// Token: 0x04005716 RID: 22294
		internal static int __PropertyOffset_OverrideValue;
	}
}
