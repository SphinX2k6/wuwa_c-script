using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000356 RID: 854
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleParameters")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FDestructibleParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002F70 RID: 12144 RVA: 0x00048A6F File Offset: 0x00046C6F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleParameters._ScriptStructPtr != 0) ? FDestructibleParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleParameters", ref FDestructibleParameters._ScriptStructPtr);
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x00048A94 File Offset: 0x00046C94
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x00048AD7 File Offset: 0x00046CD7
		public FDestructibleDamageParameters DamageParameters
		{
			get
			{
				base.FastCheckIsValid();
				FDestructibleDamageParameters result;
				if ((result = this._DamageParameters) == null)
				{
					result = (this._DamageParameters = new FDestructibleDamageParameters(base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_DamageParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDestructibleDamageParameters.StaticStruct(), base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_DamageParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x00048AF8 File Offset: 0x00046CF8
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x00048B3B File Offset: 0x00046D3B
		public FDestructibleDebrisParameters DebrisParameters
		{
			get
			{
				base.FastCheckIsValid();
				FDestructibleDebrisParameters result;
				if ((result = this._DebrisParameters) == null)
				{
					result = (this._DebrisParameters = new FDestructibleDebrisParameters(base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_DebrisParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDestructibleDebrisParameters.StaticStruct(), base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_DebrisParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x00048B5C File Offset: 0x00046D5C
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x00048B9F File Offset: 0x00046D9F
		public FDestructibleAdvancedParameters AdvancedParameters
		{
			get
			{
				base.FastCheckIsValid();
				FDestructibleAdvancedParameters result;
				if ((result = this._AdvancedParameters) == null)
				{
					result = (this._AdvancedParameters = new FDestructibleAdvancedParameters(base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_AdvancedParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDestructibleAdvancedParameters.StaticStruct(), base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_AdvancedParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x00048BC0 File Offset: 0x00046DC0
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x00048C03 File Offset: 0x00046E03
		public FDestructibleSpecialHierarchyDepths SpecialHierarchyDepths
		{
			get
			{
				base.FastCheckIsValid();
				FDestructibleSpecialHierarchyDepths result;
				if ((result = this._SpecialHierarchyDepths) == null)
				{
					result = (this._SpecialHierarchyDepths = new FDestructibleSpecialHierarchyDepths(base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_SpecialHierarchyDepths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDestructibleSpecialHierarchyDepths.StaticStruct(), base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_SpecialHierarchyDepths, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00048C24 File Offset: 0x00046E24
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x00048C67 File Offset: 0x00046E67
		public TArray<FDestructibleDepthParameters> DepthParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDestructibleDepthParameters> result;
				if ((result = this._DepthParameters) == null)
				{
					result = (this._DepthParameters = new TArray<FDestructibleDepthParameters>(base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_DepthParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DepthParameters.CopyAssign(value);
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x00048C78 File Offset: 0x00046E78
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x00048CBB File Offset: 0x00046EBB
		public FDestructibleParametersFlag Flags
		{
			get
			{
				base.FastCheckIsValid();
				FDestructibleParametersFlag result;
				if ((result = this._Flags) == null)
				{
					result = (this._Flags = new FDestructibleParametersFlag(base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_Flags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDestructibleParametersFlag.StaticStruct(), base.NativePtr + (IntPtr)FDestructibleParameters.__PropertyOffset_Flags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00048CDC File Offset: 0x00046EDC
		public FDestructibleParameters()
		{
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00048CE4 File Offset: 0x00046EE4
		public FDestructibleParameters(FDestructibleDamageParameters DamageParameters, FDestructibleDebrisParameters DebrisParameters, FDestructibleAdvancedParameters AdvancedParameters, FDestructibleSpecialHierarchyDepths SpecialHierarchyDepths, TArray<FDestructibleDepthParameters> DepthParameters, FDestructibleParametersFlag Flags)
		{
			this.DamageParameters = DamageParameters;
			this.DebrisParameters = DebrisParameters;
			this.AdvancedParameters = AdvancedParameters;
			this.SpecialHierarchyDepths = SpecialHierarchyDepths;
			this.DepthParameters = DepthParameters;
			this.Flags = Flags;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00048D19 File Offset: 0x00046F19
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleParameters.StaticStruct();
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00048D25 File Offset: 0x00046F25
		[NullableContext(2)]
		public FDestructibleParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00048D2F File Offset: 0x00046F2F
		public FDestructibleParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00048D3A File Offset: 0x00046F3A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleParameters(Pointer, false, true);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00048D44 File Offset: 0x00046F44
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400147E RID: 5246
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleParameters";

		// Token: 0x0400147F RID: 5247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001480 RID: 5248
		internal static int __PropertyOffset_DamageParameters;

		// Token: 0x04001481 RID: 5249
		[Nullable(2)]
		private FDestructibleDamageParameters _DamageParameters;

		// Token: 0x04001482 RID: 5250
		internal static int __PropertyOffset_DebrisParameters;

		// Token: 0x04001483 RID: 5251
		[Nullable(2)]
		private FDestructibleDebrisParameters _DebrisParameters;

		// Token: 0x04001484 RID: 5252
		internal static int __PropertyOffset_AdvancedParameters;

		// Token: 0x04001485 RID: 5253
		[Nullable(2)]
		private FDestructibleAdvancedParameters _AdvancedParameters;

		// Token: 0x04001486 RID: 5254
		internal static int __PropertyOffset_SpecialHierarchyDepths;

		// Token: 0x04001487 RID: 5255
		[Nullable(2)]
		private FDestructibleSpecialHierarchyDepths _SpecialHierarchyDepths;

		// Token: 0x04001488 RID: 5256
		internal static int __PropertyOffset_DepthParameters;

		// Token: 0x04001489 RID: 5257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDestructibleDepthParameters> _DepthParameters;

		// Token: 0x0400148A RID: 5258
		internal static int __PropertyOffset_Flags;

		// Token: 0x0400148B RID: 5259
		[Nullable(2)]
		private FDestructibleParametersFlag _Flags;
	}
}
