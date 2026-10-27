using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AC9 RID: 6857
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMatCustomParamConfigs")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroCharWetMatCustomParamConfigs : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060197CC RID: 104396 RVA: 0x0025A94A File Offset: 0x00258B4A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharWetMatCustomParamConfigs._ScriptStructPtr != 0) ? FKuroCharWetMatCustomParamConfigs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMatCustomParamConfigs", ref FKuroCharWetMatCustomParamConfigs._ScriptStructPtr);
		}

		// Token: 0x170065A0 RID: 26016
		// (get) Token: 0x060197CD RID: 104397 RVA: 0x0025A96E File Offset: 0x00258B6E
		// (set) Token: 0x060197CE RID: 104398 RVA: 0x0025A97E File Offset: 0x00258B7E
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharWetMatCustomParamConfigs.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharWetMatCustomParamConfigs.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x170065A1 RID: 26017
		// (get) Token: 0x060197CF RID: 104399 RVA: 0x0025A990 File Offset: 0x00258B90
		// (set) Token: 0x060197D0 RID: 104400 RVA: 0x0025A9D3 File Offset: 0x00258BD3
		public TArray<FKuroCharWetMatNamedFloatParam> CustomFloatParam
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharWetMatNamedFloatParam> result;
				if ((result = this._CustomFloatParam) == null)
				{
					result = (this._CustomFloatParam = new TArray<FKuroCharWetMatNamedFloatParam>(base.NativePtr + (IntPtr)FKuroCharWetMatCustomParamConfigs.__PropertyOffset_CustomFloatParam, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParam.CopyAssign(value);
			}
		}

		// Token: 0x060197D1 RID: 104401 RVA: 0x0025A9E1 File Offset: 0x00258BE1
		public FKuroCharWetMatCustomParamConfigs()
		{
		}

		// Token: 0x060197D2 RID: 104402 RVA: 0x0025A9E9 File Offset: 0x00258BE9
		public FKuroCharWetMatCustomParamConfigs(int MaterialIndex, TArray<FKuroCharWetMatNamedFloatParam> CustomFloatParam)
		{
			this.MaterialIndex = MaterialIndex;
			this.CustomFloatParam = CustomFloatParam;
		}

		// Token: 0x060197D3 RID: 104403 RVA: 0x0025A9FF File Offset: 0x00258BFF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharWetMatCustomParamConfigs.StaticStruct();
		}

		// Token: 0x060197D4 RID: 104404 RVA: 0x0025AA0B File Offset: 0x00258C0B
		[NullableContext(2)]
		public FKuroCharWetMatCustomParamConfigs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060197D5 RID: 104405 RVA: 0x0025AA15 File Offset: 0x00258C15
		public FKuroCharWetMatCustomParamConfigs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060197D6 RID: 104406 RVA: 0x0025AA20 File Offset: 0x00258C20
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharWetMatCustomParamConfigs(Pointer, false, true);
		}

		// Token: 0x060197D7 RID: 104407 RVA: 0x0025AA2A File Offset: 0x00258C2A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharWetMatCustomParamConfigs(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDF2 RID: 56818
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMatCustomParamConfigs";

		// Token: 0x0400DDF3 RID: 56819
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDF4 RID: 56820
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x0400DDF5 RID: 56821
		internal static int __PropertyOffset_CustomFloatParam;

		// Token: 0x0400DDF6 RID: 56822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharWetMatNamedFloatParam> _CustomFloatParam;
	}
}
