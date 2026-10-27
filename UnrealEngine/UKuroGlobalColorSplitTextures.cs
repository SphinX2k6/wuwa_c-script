using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B0E RID: 6926
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalColorSplitTextures")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroGlobalColorSplitTextures : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019F75 RID: 106357 RVA: 0x00265AC0 File Offset: 0x00263CC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGlobalColorSplitTextures._ClassPtr;
		}

		// Token: 0x06019F76 RID: 106358 RVA: 0x00265ACC File Offset: 0x00263CCC
		public UKuroGlobalColorSplitTextures() : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalColorSplitTextures.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019F77 RID: 106359 RVA: 0x00265AF4 File Offset: 0x00263CF4
		public UKuroGlobalColorSplitTextures(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalColorSplitTextures.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700681D RID: 26653
		// (get) Token: 0x06019F78 RID: 106360 RVA: 0x00265B28 File Offset: 0x00263D28
		// (set) Token: 0x06019F79 RID: 106361 RVA: 0x00265B61 File Offset: 0x00263D61
		public TMap<FWPCoord, TSoftObjectPtr<UTexture2D>> CoordTexPair
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FWPCoord, TSoftObjectPtr<UTexture2D>> result;
				if ((result = this._CoordTexPair) == null)
				{
					result = (this._CoordTexPair = new TMap<FWPCoord, TSoftObjectPtr<UTexture2D>>(base.NativePtr + (IntPtr)UKuroGlobalColorSplitTextures.__PropertyOffset_CoordTexPair, this));
				}
				return result;
			}
			set
			{
				this.CoordTexPair.CopyAssign(value);
			}
		}

		// Token: 0x06019F7A RID: 106362 RVA: 0x00265B6F File Offset: 0x00263D6F
		static UKuroGlobalColorSplitTextures()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalColorSplitTextures");
		}

		// Token: 0x06019F7B RID: 106363 RVA: 0x00265B7D File Offset: 0x00263D7D
		protected UKuroGlobalColorSplitTextures(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E1E0 RID: 57824
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalColorSplitTextures";

		// Token: 0x0400E1E1 RID: 57825
		private static IntPtr _ClassPtr;

		// Token: 0x0400E1E2 RID: 57826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E1E3 RID: 57827
		internal static int __PropertyOffset_CoordTexPair;

		// Token: 0x0400E1E4 RID: 57828
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<FWPCoord, TSoftObjectPtr<UTexture2D>> _CoordTexPair;
	}
}
