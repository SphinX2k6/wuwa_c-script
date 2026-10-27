using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D7B RID: 3451
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialCachedParameterEntry")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMaterialCachedParameterEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BCA3 RID: 48291 RVA: 0x0010D788 File Offset: 0x0010B988
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialCachedParameterEntry._ScriptStructPtr != 0) ? FMaterialCachedParameterEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialCachedParameterEntry", ref FMaterialCachedParameterEntry._ScriptStructPtr);
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x0600BCA4 RID: 48292 RVA: 0x0010D7AC File Offset: 0x0010B9AC
		// (set) Token: 0x0600BCA5 RID: 48293 RVA: 0x0010D7EF File Offset: 0x0010B9EF
		public TArray<ulong> NameHashes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ulong> result;
				if ((result = this._NameHashes) == null)
				{
					result = (this._NameHashes = new TArray<ulong>(base.NativePtr + (IntPtr)FMaterialCachedParameterEntry.__PropertyOffset_NameHashes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameHashes.CopyAssign(value);
			}
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x0600BCA6 RID: 48294 RVA: 0x0010D800 File Offset: 0x0010BA00
		// (set) Token: 0x0600BCA7 RID: 48295 RVA: 0x0010D843 File Offset: 0x0010BA43
		public TArray<FMaterialParameterInfo> ParameterInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMaterialParameterInfo> result;
				if ((result = this._ParameterInfos) == null)
				{
					result = (this._ParameterInfos = new TArray<FMaterialParameterInfo>(base.NativePtr + (IntPtr)FMaterialCachedParameterEntry.__PropertyOffset_ParameterInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParameterInfos.CopyAssign(value);
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x0600BCA8 RID: 48296 RVA: 0x0010D854 File Offset: 0x0010BA54
		// (set) Token: 0x0600BCA9 RID: 48297 RVA: 0x0010D897 File Offset: 0x0010BA97
		public TArray<FGuid> ExpressionGuids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._ExpressionGuids) == null)
				{
					result = (this._ExpressionGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)FMaterialCachedParameterEntry.__PropertyOffset_ExpressionGuids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExpressionGuids.CopyAssign(value);
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x0010D8A8 File Offset: 0x0010BAA8
		// (set) Token: 0x0600BCAB RID: 48299 RVA: 0x0010D8EB File Offset: 0x0010BAEB
		public TArray<bool> Overrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._Overrides) == null)
				{
					result = (this._Overrides = new TArray<bool>(base.NativePtr + (IntPtr)FMaterialCachedParameterEntry.__PropertyOffset_Overrides, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Overrides.CopyAssign(value);
			}
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x0010D8F9 File Offset: 0x0010BAF9
		public FMaterialCachedParameterEntry()
		{
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x0010D901 File Offset: 0x0010BB01
		public FMaterialCachedParameterEntry(TArray<ulong> NameHashes, TArray<FMaterialParameterInfo> ParameterInfos, TArray<FGuid> ExpressionGuids, TArray<bool> Overrides)
		{
			this.NameHashes = NameHashes;
			this.ParameterInfos = ParameterInfos;
			this.ExpressionGuids = ExpressionGuids;
			this.Overrides = Overrides;
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x0010D926 File Offset: 0x0010BB26
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialCachedParameterEntry.StaticStruct();
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x0010D932 File Offset: 0x0010BB32
		[NullableContext(2)]
		public FMaterialCachedParameterEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x0010D93C File Offset: 0x0010BB3C
		public FMaterialCachedParameterEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x0010D947 File Offset: 0x0010BB47
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialCachedParameterEntry(Pointer, false, true);
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x0010D951 File Offset: 0x0010BB51
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialCachedParameterEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400636F RID: 25455
		public const string __ObjectPath = "/Script/Engine.MaterialCachedParameterEntry";

		// Token: 0x04006370 RID: 25456
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006371 RID: 25457
		internal static int __PropertyOffset_NameHashes;

		// Token: 0x04006372 RID: 25458
		[Nullable(2)]
		private TArray<ulong> _NameHashes;

		// Token: 0x04006373 RID: 25459
		internal static int __PropertyOffset_ParameterInfos;

		// Token: 0x04006374 RID: 25460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMaterialParameterInfo> _ParameterInfos;

		// Token: 0x04006375 RID: 25461
		internal static int __PropertyOffset_ExpressionGuids;

		// Token: 0x04006376 RID: 25462
		[Nullable(2)]
		private TArray<FGuid> _ExpressionGuids;

		// Token: 0x04006377 RID: 25463
		internal static int __PropertyOffset_Overrides;

		// Token: 0x04006378 RID: 25464
		[Nullable(2)]
		private TArray<bool> _Overrides;
	}
}
