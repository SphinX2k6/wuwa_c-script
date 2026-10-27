using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200201C RID: 8220
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIArtTextData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULGUIArtTextData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF8F RID: 126863 RVA: 0x002E0F30 File Offset: 0x002DF130
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIArtTextData._ClassPtr;
		}

		// Token: 0x0601EF90 RID: 126864 RVA: 0x002E0F3C File Offset: 0x002DF13C
		public ULGUIArtTextData() : this(BuiltinUtils.AllocNativeUObject(ULGUIArtTextData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF91 RID: 126865 RVA: 0x002E0F64 File Offset: 0x002DF164
		public ULGUIArtTextData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIArtTextData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B49 RID: 31561
		// (get) Token: 0x0601EF92 RID: 126866 RVA: 0x002E0F98 File Offset: 0x002DF198
		// (set) Token: 0x0601EF93 RID: 126867 RVA: 0x002E0FD1 File Offset: 0x002DF1D1
		public TArray<FUIArtTextInfo> ArtTextInfoArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FUIArtTextInfo> result;
				if ((result = this._ArtTextInfoArray) == null)
				{
					result = (this._ArtTextInfoArray = new TArray<FUIArtTextInfo>(base.NativePtr + (IntPtr)ULGUIArtTextData.__PropertyOffset_ArtTextInfoArray, this));
				}
				return result;
			}
			set
			{
				this.ArtTextInfoArray.CopyAssign(value);
			}
		}

		// Token: 0x0601EF94 RID: 126868 RVA: 0x002E0FDF File Offset: 0x002DF1DF
		public TArray<FUIArtTextInfo> GetArtTextInfoArray()
		{
			return new TArray<FUIArtTextInfo>(ULGUIArtTextData.__GetArtTextInfoArray_Internal(base.NativePtr), null);
		}

		// Token: 0x0601EF95 RID: 126869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetArtTextInfoArray_Internal(IntPtr @this);

		// Token: 0x0601EF96 RID: 126870 RVA: 0x002E0FF2 File Offset: 0x002DF1F2
		static ULGUIArtTextData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIArtTextData");
		}

		// Token: 0x0601EF97 RID: 126871 RVA: 0x002E1000 File Offset: 0x002DF200
		protected ULGUIArtTextData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D67 RID: 68967
		public new const string __ObjectPath = "/Script/LGUI.LGUIArtTextData";

		// Token: 0x04010D68 RID: 68968
		private static IntPtr _ClassPtr;

		// Token: 0x04010D69 RID: 68969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D6A RID: 68970
		internal static int __PropertyOffset_ArtTextInfoArray;

		// Token: 0x04010D6B RID: 68971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FUIArtTextInfo> _ArtTextInfoArray;
	}
}
