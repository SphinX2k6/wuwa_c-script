using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C38 RID: 3128
	[UnrealObjectPath("/Script/Engine.HLODModifierScalarParameter")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FHLODModifierScalarParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009E8E RID: 40590 RVA: 0x000E15CB File Offset: 0x000DF7CB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODModifierScalarParameter._ScriptStructPtr != 0) ? FHLODModifierScalarParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODModifierScalarParameter", ref FHLODModifierScalarParameter._ScriptStructPtr);
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x06009E8F RID: 40591 RVA: 0x000E15EF File Offset: 0x000DF7EF
		// (set) Token: 0x06009E90 RID: 40592 RVA: 0x000E1603 File Offset: 0x000DF803
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHLODModifierScalarParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHLODModifierScalarParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x06009E91 RID: 40593 RVA: 0x000E1618 File Offset: 0x000DF818
		// (set) Token: 0x06009E92 RID: 40594 RVA: 0x000E1628 File Offset: 0x000DF828
		public unsafe float OverrideValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHLODModifierScalarParameter.__PropertyOffset_OverrideValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHLODModifierScalarParameter.__PropertyOffset_OverrideValue) = value;
			}
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x000E1639 File Offset: 0x000DF839
		public FHLODModifierScalarParameter()
		{
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x000E1641 File Offset: 0x000DF841
		public FHLODModifierScalarParameter(FName ParameterName, float OverrideValue)
		{
			this.ParameterName = ParameterName;
			this.OverrideValue = OverrideValue;
		}

		// Token: 0x06009E95 RID: 40597 RVA: 0x000E1657 File Offset: 0x000DF857
		protected override IntPtr GetUStructPtr()
		{
			return FHLODModifierScalarParameter.StaticStruct();
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x000E1663 File Offset: 0x000DF863
		[NullableContext(2)]
		public FHLODModifierScalarParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x000E166D File Offset: 0x000DF86D
		public FHLODModifierScalarParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x000E1678 File Offset: 0x000DF878
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODModifierScalarParameter(Pointer, false, true);
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x000E1682 File Offset: 0x000DF882
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODModifierScalarParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04005768 RID: 22376
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HLODModifierScalarParameter";

		// Token: 0x04005769 RID: 22377
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400576A RID: 22378
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400576B RID: 22379
		internal static int __PropertyOffset_OverrideValue;
	}
}
