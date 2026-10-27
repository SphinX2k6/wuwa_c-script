using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001050 RID: 4176
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigShader")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FPSOGeneratorConfigShader : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED99 RID: 60825 RVA: 0x001609E0 File Offset: 0x0015EBE0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigShader._ScriptStructPtr != 0) ? FPSOGeneratorConfigShader._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigShader", ref FPSOGeneratorConfigShader._ScriptStructPtr);
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0600ED9A RID: 60826 RVA: 0x00160A04 File Offset: 0x0015EC04
		// (set) Token: 0x0600ED9B RID: 60827 RVA: 0x00160A47 File Offset: 0x0015EC47
		public FPSOGeneratorConfigSingleShader VertexShader
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigSingleShader result;
				if ((result = this._VertexShader) == null)
				{
					result = (this._VertexShader = new FPSOGeneratorConfigSingleShader(base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_VertexShader, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigSingleShader.StaticStruct(), base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_VertexShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0600ED9C RID: 60828 RVA: 0x00160A68 File Offset: 0x0015EC68
		// (set) Token: 0x0600ED9D RID: 60829 RVA: 0x00160AAB File Offset: 0x0015ECAB
		public FPSOGeneratorConfigSingleShader FragmentShader
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigSingleShader result;
				if ((result = this._FragmentShader) == null)
				{
					result = (this._FragmentShader = new FPSOGeneratorConfigSingleShader(base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_FragmentShader, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigSingleShader.StaticStruct(), base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_FragmentShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0600ED9E RID: 60830 RVA: 0x00160ACC File Offset: 0x0015ECCC
		// (set) Token: 0x0600ED9F RID: 60831 RVA: 0x00160B0F File Offset: 0x0015ED0F
		public FPSOGeneratorConfigSingleShader GeometryShader
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigSingleShader result;
				if ((result = this._GeometryShader) == null)
				{
					result = (this._GeometryShader = new FPSOGeneratorConfigSingleShader(base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_GeometryShader, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigSingleShader.StaticStruct(), base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_GeometryShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0600EDA0 RID: 60832 RVA: 0x00160B30 File Offset: 0x0015ED30
		// (set) Token: 0x0600EDA1 RID: 60833 RVA: 0x00160B73 File Offset: 0x0015ED73
		public FPSOGeneratorConfigSingleShader HullShader
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigSingleShader result;
				if ((result = this._HullShader) == null)
				{
					result = (this._HullShader = new FPSOGeneratorConfigSingleShader(base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_HullShader, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigSingleShader.StaticStruct(), base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_HullShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0600EDA2 RID: 60834 RVA: 0x00160B94 File Offset: 0x0015ED94
		// (set) Token: 0x0600EDA3 RID: 60835 RVA: 0x00160BD7 File Offset: 0x0015EDD7
		public FPSOGeneratorConfigSingleShader DomainShader
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigSingleShader result;
				if ((result = this._DomainShader) == null)
				{
					result = (this._DomainShader = new FPSOGeneratorConfigSingleShader(base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_DomainShader, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigSingleShader.StaticStruct(), base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_DomainShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600EDA4 RID: 60836 RVA: 0x00160BF8 File Offset: 0x0015EDF8
		// (set) Token: 0x0600EDA5 RID: 60837 RVA: 0x00160C3B File Offset: 0x0015EE3B
		public FPSOGeneratorConfigSingleShader ComputeShader
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigSingleShader result;
				if ((result = this._ComputeShader) == null)
				{
					result = (this._ComputeShader = new FPSOGeneratorConfigSingleShader(base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_ComputeShader, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigSingleShader.StaticStruct(), base.NativePtr + (IntPtr)FPSOGeneratorConfigShader.__PropertyOffset_ComputeShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600EDA6 RID: 60838 RVA: 0x00160C5C File Offset: 0x0015EE5C
		public FPSOGeneratorConfigShader()
		{
		}

		// Token: 0x0600EDA7 RID: 60839 RVA: 0x00160C64 File Offset: 0x0015EE64
		public FPSOGeneratorConfigShader(FPSOGeneratorConfigSingleShader VertexShader, FPSOGeneratorConfigSingleShader FragmentShader, FPSOGeneratorConfigSingleShader GeometryShader, FPSOGeneratorConfigSingleShader HullShader, FPSOGeneratorConfigSingleShader DomainShader, FPSOGeneratorConfigSingleShader ComputeShader)
		{
			this.VertexShader = VertexShader;
			this.FragmentShader = FragmentShader;
			this.GeometryShader = GeometryShader;
			this.HullShader = HullShader;
			this.DomainShader = DomainShader;
			this.ComputeShader = ComputeShader;
		}

		// Token: 0x0600EDA8 RID: 60840 RVA: 0x00160C99 File Offset: 0x0015EE99
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigShader.StaticStruct();
		}

		// Token: 0x0600EDA9 RID: 60841 RVA: 0x00160CA5 File Offset: 0x0015EEA5
		[NullableContext(2)]
		public FPSOGeneratorConfigShader(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EDAA RID: 60842 RVA: 0x00160CAF File Offset: 0x0015EEAF
		public FPSOGeneratorConfigShader(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EDAB RID: 60843 RVA: 0x00160CBA File Offset: 0x0015EEBA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigShader(Pointer, false, true);
		}

		// Token: 0x0600EDAC RID: 60844 RVA: 0x00160CC4 File Offset: 0x0015EEC4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigShader(Pointer, MemoryOwner);
		}

		// Token: 0x040080B1 RID: 32945
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigShader";

		// Token: 0x040080B2 RID: 32946
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080B3 RID: 32947
		internal static int __PropertyOffset_VertexShader;

		// Token: 0x040080B4 RID: 32948
		[Nullable(2)]
		private FPSOGeneratorConfigSingleShader _VertexShader;

		// Token: 0x040080B5 RID: 32949
		internal static int __PropertyOffset_FragmentShader;

		// Token: 0x040080B6 RID: 32950
		[Nullable(2)]
		private FPSOGeneratorConfigSingleShader _FragmentShader;

		// Token: 0x040080B7 RID: 32951
		internal static int __PropertyOffset_GeometryShader;

		// Token: 0x040080B8 RID: 32952
		[Nullable(2)]
		private FPSOGeneratorConfigSingleShader _GeometryShader;

		// Token: 0x040080B9 RID: 32953
		internal static int __PropertyOffset_HullShader;

		// Token: 0x040080BA RID: 32954
		[Nullable(2)]
		private FPSOGeneratorConfigSingleShader _HullShader;

		// Token: 0x040080BB RID: 32955
		internal static int __PropertyOffset_DomainShader;

		// Token: 0x040080BC RID: 32956
		[Nullable(2)]
		private FPSOGeneratorConfigSingleShader _DomainShader;

		// Token: 0x040080BD RID: 32957
		internal static int __PropertyOffset_ComputeShader;

		// Token: 0x040080BE RID: 32958
		[Nullable(2)]
		private FPSOGeneratorConfigSingleShader _ComputeShader;
	}
}
