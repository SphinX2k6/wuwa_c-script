using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D7C RID: 3452
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialCachedParameters")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 736)]
	public class FMaterialCachedParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BCB3 RID: 48307 RVA: 0x0010D95A File Offset: 0x0010BB5A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialCachedParameters._ScriptStructPtr != 0) ? FMaterialCachedParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialCachedParameters", ref FMaterialCachedParameters._ScriptStructPtr);
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x0600BCB4 RID: 48308 RVA: 0x0010D980 File Offset: 0x0010BB80
		// (set) Token: 0x0600BCB5 RID: 48309 RVA: 0x0010D9C4 File Offset: 0x0010BBC4
		public TFixedArray<FMaterialCachedParameterEntry> RuntimeEntries
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMaterialCachedParameterEntry> result;
				if ((result = this._RuntimeEntries) == null)
				{
					result = (this._RuntimeEntries = new TFixedArray<FMaterialCachedParameterEntry>(base.NativePtr + (IntPtr)FMaterialCachedParameters.__PropertyOffset_RuntimeEntries, 6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RuntimeEntries.CopyAssign(value);
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x0600BCB6 RID: 48310 RVA: 0x0010D9D4 File Offset: 0x0010BBD4
		// (set) Token: 0x0600BCB7 RID: 48311 RVA: 0x0010DA17 File Offset: 0x0010BC17
		public TArray<float> ScalarValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ScalarValues) == null)
				{
					result = (this._ScalarValues = new TArray<float>(base.NativePtr + (IntPtr)FMaterialCachedParameters.__PropertyOffset_ScalarValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScalarValues.CopyAssign(value);
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x0600BCB8 RID: 48312 RVA: 0x0010DA28 File Offset: 0x0010BC28
		// (set) Token: 0x0600BCB9 RID: 48313 RVA: 0x0010DA6B File Offset: 0x0010BC6B
		public TArray<FLinearColor> VectorValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._VectorValues) == null)
				{
					result = (this._VectorValues = new TArray<FLinearColor>(base.NativePtr + (IntPtr)FMaterialCachedParameters.__PropertyOffset_VectorValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorValues.CopyAssign(value);
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x0600BCBA RID: 48314 RVA: 0x0010DA7C File Offset: 0x0010BC7C
		// (set) Token: 0x0600BCBB RID: 48315 RVA: 0x0010DABF File Offset: 0x0010BCBF
		public TArray<UTexture> TextureValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture> result;
				if ((result = this._TextureValues) == null)
				{
					result = (this._TextureValues = new TArray<UTexture>(base.NativePtr + (IntPtr)FMaterialCachedParameters.__PropertyOffset_TextureValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureValues.CopyAssign(value);
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x0600BCBC RID: 48316 RVA: 0x0010DAD0 File Offset: 0x0010BCD0
		// (set) Token: 0x0600BCBD RID: 48317 RVA: 0x0010DB13 File Offset: 0x0010BD13
		public TArray<UFont> FontValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UFont> result;
				if ((result = this._FontValues) == null)
				{
					result = (this._FontValues = new TArray<UFont>(base.NativePtr + (IntPtr)FMaterialCachedParameters.__PropertyOffset_FontValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FontValues.CopyAssign(value);
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x0010DB24 File Offset: 0x0010BD24
		// (set) Token: 0x0600BCBF RID: 48319 RVA: 0x0010DB67 File Offset: 0x0010BD67
		public TArray<int> FontPageValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._FontPageValues) == null)
				{
					result = (this._FontPageValues = new TArray<int>(base.NativePtr + (IntPtr)FMaterialCachedParameters.__PropertyOffset_FontPageValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FontPageValues.CopyAssign(value);
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x0600BCC0 RID: 48320 RVA: 0x0010DB78 File Offset: 0x0010BD78
		// (set) Token: 0x0600BCC1 RID: 48321 RVA: 0x0010DBBB File Offset: 0x0010BDBB
		public TArray<URuntimeVirtualTexture> RuntimeVirtualTextureValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URuntimeVirtualTexture> result;
				if ((result = this._RuntimeVirtualTextureValues) == null)
				{
					result = (this._RuntimeVirtualTextureValues = new TArray<URuntimeVirtualTexture>(base.NativePtr + (IntPtr)FMaterialCachedParameters.__PropertyOffset_RuntimeVirtualTextureValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RuntimeVirtualTextureValues.CopyAssign(value);
			}
		}

		// Token: 0x0600BCC2 RID: 48322 RVA: 0x0010DBC9 File Offset: 0x0010BDC9
		public FMaterialCachedParameters()
		{
		}

		// Token: 0x0600BCC3 RID: 48323 RVA: 0x0010DBD1 File Offset: 0x0010BDD1
		public FMaterialCachedParameters(TFixedArray<FMaterialCachedParameterEntry> RuntimeEntries, TArray<float> ScalarValues, TArray<FLinearColor> VectorValues, TArray<UTexture> TextureValues, TArray<UFont> FontValues, TArray<int> FontPageValues, TArray<URuntimeVirtualTexture> RuntimeVirtualTextureValues, TFixedArray<FMaterialCachedParameterEntry> EditorOnlyEntries, TArray<bool> StaticSwitchValues, TArray<FStaticComponentMaskValue> StaticComponentMaskValues, TArray<FVector2D> ScalarMinMaxValues, TArray<UCurveLinearColor> ScalarCurveValues, TArray<UCurveLinearColorAtlas> ScalarCurveAtlasValues, TArray<FParameterChannelNames> VectorChannelNameValues, TArray<bool> VectorUsedAsChannelMaskValues, TArray<FParameterChannelNames> TextureChannelNameValues)
		{
			this.RuntimeEntries = RuntimeEntries;
			this.ScalarValues = ScalarValues;
			this.VectorValues = VectorValues;
			this.TextureValues = TextureValues;
			this.FontValues = FontValues;
			this.FontPageValues = FontPageValues;
			this.RuntimeVirtualTextureValues = RuntimeVirtualTextureValues;
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x0010DC0E File Offset: 0x0010BE0E
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialCachedParameters.StaticStruct();
		}

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x0010DC1A File Offset: 0x0010BE1A
		[NullableContext(2)]
		public FMaterialCachedParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BCC6 RID: 48326 RVA: 0x0010DC24 File Offset: 0x0010BE24
		public FMaterialCachedParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BCC7 RID: 48327 RVA: 0x0010DC2F File Offset: 0x0010BE2F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialCachedParameters(Pointer, false, true);
		}

		// Token: 0x0600BCC8 RID: 48328 RVA: 0x0010DC39 File Offset: 0x0010BE39
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialCachedParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04006379 RID: 25465
		public const string __ObjectPath = "/Script/Engine.MaterialCachedParameters";

		// Token: 0x0400637A RID: 25466
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400637B RID: 25467
		internal static int __PropertyOffset_RuntimeEntries;

		// Token: 0x0400637C RID: 25468
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMaterialCachedParameterEntry> _RuntimeEntries;

		// Token: 0x0400637D RID: 25469
		internal static int __PropertyOffset_ScalarValues;

		// Token: 0x0400637E RID: 25470
		[Nullable(2)]
		private TArray<float> _ScalarValues;

		// Token: 0x0400637F RID: 25471
		internal static int __PropertyOffset_VectorValues;

		// Token: 0x04006380 RID: 25472
		[Nullable(2)]
		private TArray<FLinearColor> _VectorValues;

		// Token: 0x04006381 RID: 25473
		internal static int __PropertyOffset_TextureValues;

		// Token: 0x04006382 RID: 25474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture> _TextureValues;

		// Token: 0x04006383 RID: 25475
		internal static int __PropertyOffset_FontValues;

		// Token: 0x04006384 RID: 25476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UFont> _FontValues;

		// Token: 0x04006385 RID: 25477
		internal static int __PropertyOffset_FontPageValues;

		// Token: 0x04006386 RID: 25478
		[Nullable(2)]
		private TArray<int> _FontPageValues;

		// Token: 0x04006387 RID: 25479
		internal static int __PropertyOffset_RuntimeVirtualTextureValues;

		// Token: 0x04006388 RID: 25480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URuntimeVirtualTexture> _RuntimeVirtualTextureValues;
	}
}
