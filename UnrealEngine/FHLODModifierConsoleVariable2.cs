using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F47 RID: 8007
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroWorldPartition.HLODModifierConsoleVariable2")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FHLODModifierConsoleVariable2 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E755 RID: 124757 RVA: 0x002D47A3 File Offset: 0x002D29A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODModifierConsoleVariable2._ScriptStructPtr != 0) ? FHLODModifierConsoleVariable2._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroWorldPartition.HLODModifierConsoleVariable2", ref FHLODModifierConsoleVariable2._ScriptStructPtr);
		}

		// Token: 0x17007923 RID: 31011
		// (get) Token: 0x0601E756 RID: 124758 RVA: 0x002D47C7 File Offset: 0x002D29C7
		// (set) Token: 0x0601E757 RID: 124759 RVA: 0x002D47DB File Offset: 0x002D29DB
		public unsafe string VariableName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODModifierConsoleVariable2.__PropertyOffset_VariableName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODModifierConsoleVariable2.__PropertyOffset_VariableName)), value);
			}
		}

		// Token: 0x17007924 RID: 31012
		// (get) Token: 0x0601E758 RID: 124760 RVA: 0x002D47F0 File Offset: 0x002D29F0
		// (set) Token: 0x0601E759 RID: 124761 RVA: 0x002D4804 File Offset: 0x002D2A04
		public unsafe string OverrideValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODModifierConsoleVariable2.__PropertyOffset_OverrideValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODModifierConsoleVariable2.__PropertyOffset_OverrideValue)), value);
			}
		}

		// Token: 0x0601E75A RID: 124762 RVA: 0x002D4819 File Offset: 0x002D2A19
		public FHLODModifierConsoleVariable2()
		{
		}

		// Token: 0x0601E75B RID: 124763 RVA: 0x002D4821 File Offset: 0x002D2A21
		public FHLODModifierConsoleVariable2(string VariableName, string OverrideValue)
		{
			this.VariableName = VariableName;
			this.OverrideValue = OverrideValue;
		}

		// Token: 0x0601E75C RID: 124764 RVA: 0x002D4837 File Offset: 0x002D2A37
		protected override IntPtr GetUStructPtr()
		{
			return FHLODModifierConsoleVariable2.StaticStruct();
		}

		// Token: 0x0601E75D RID: 124765 RVA: 0x002D4843 File Offset: 0x002D2A43
		[NullableContext(2)]
		public FHLODModifierConsoleVariable2(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E75E RID: 124766 RVA: 0x002D484D File Offset: 0x002D2A4D
		public FHLODModifierConsoleVariable2(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E75F RID: 124767 RVA: 0x002D4858 File Offset: 0x002D2A58
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODModifierConsoleVariable2(Pointer, false, true);
		}

		// Token: 0x0601E760 RID: 124768 RVA: 0x002D4862 File Offset: 0x002D2A62
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODModifierConsoleVariable2(Pointer, MemoryOwner);
		}

		// Token: 0x040106E7 RID: 67303
		public const string __ObjectPath = "/Script/KuroWorldPartition.HLODModifierConsoleVariable2";

		// Token: 0x040106E8 RID: 67304
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040106E9 RID: 67305
		internal static int __PropertyOffset_VariableName;

		// Token: 0x040106EA RID: 67306
		internal static int __PropertyOffset_OverrideValue;
	}
}
