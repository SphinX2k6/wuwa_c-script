using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B83 RID: 7043
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacementBoundHelper")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class AKuroNvClothPlacementBoundHelper : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AB9C RID: 109468 RVA: 0x0027603C File Offset: 0x0027423C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNvClothPlacementBoundHelper._ClassPtr;
		}

		// Token: 0x0601AB9D RID: 109469 RVA: 0x00276048 File Offset: 0x00274248
		public AKuroNvClothPlacementBoundHelper() : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothPlacementBoundHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AB9E RID: 109470 RVA: 0x00276070 File Offset: 0x00274270
		public AKuroNvClothPlacementBoundHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothPlacementBoundHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B7D RID: 27517
		// (get) Token: 0x0601AB9F RID: 109471 RVA: 0x002760A4 File Offset: 0x002742A4
		// (set) Token: 0x0601ABA0 RID: 109472 RVA: 0x002760DD File Offset: 0x002742DD
		public TArray<AKuroNvClothPlacement> NvClothPlacementArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AKuroNvClothPlacement> result;
				if ((result = this._NvClothPlacementArray) == null)
				{
					result = (this._NvClothPlacementArray = new TArray<AKuroNvClothPlacement>(base.NativePtr + (IntPtr)AKuroNvClothPlacementBoundHelper.__PropertyOffset_NvClothPlacementArray, this));
				}
				return result;
			}
			set
			{
				this.NvClothPlacementArray.CopyAssign(value);
			}
		}

		// Token: 0x0601ABA1 RID: 109473 RVA: 0x002760EB File Offset: 0x002742EB
		static AKuroNvClothPlacementBoundHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacementBoundHelper");
		}

		// Token: 0x0601ABA2 RID: 109474 RVA: 0x002760F9 File Offset: 0x002742F9
		protected AKuroNvClothPlacementBoundHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E74F RID: 59215
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothPlacementBoundHelper";

		// Token: 0x0400E750 RID: 59216
		private static IntPtr _ClassPtr;

		// Token: 0x0400E751 RID: 59217
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E752 RID: 59218
		internal static int __PropertyOffset_NvClothPlacementArray;

		// Token: 0x0400E753 RID: 59219
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AKuroNvClothPlacement> _NvClothPlacementArray;
	}
}
