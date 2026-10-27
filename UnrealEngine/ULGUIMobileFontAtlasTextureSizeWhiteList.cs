using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200208A RID: 8330
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIMobileFontAtlasTextureSizeWhiteList")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class ULGUIMobileFontAtlasTextureSizeWhiteList : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F6D8 RID: 128728 RVA: 0x002EADDD File Offset: 0x002E8FDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIMobileFontAtlasTextureSizeWhiteList._ClassPtr;
		}

		// Token: 0x0601F6D9 RID: 128729 RVA: 0x002EADEC File Offset: 0x002E8FEC
		public ULGUIMobileFontAtlasTextureSizeWhiteList() : this(BuiltinUtils.AllocNativeUObject(ULGUIMobileFontAtlasTextureSizeWhiteList.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F6DA RID: 128730 RVA: 0x002EAE14 File Offset: 0x002E9014
		public ULGUIMobileFontAtlasTextureSizeWhiteList(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIMobileFontAtlasTextureSizeWhiteList.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C0C RID: 31756
		// (get) Token: 0x0601F6DB RID: 128731 RVA: 0x002EAE48 File Offset: 0x002E9048
		// (set) Token: 0x0601F6DC RID: 128732 RVA: 0x002EAE81 File Offset: 0x002E9081
		public TSet<string> CustomDevice
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._CustomDevice) == null)
				{
					result = (this._CustomDevice = new TSet<string>(base.NativePtr + (IntPtr)ULGUIMobileFontAtlasTextureSizeWhiteList.__PropertyOffset_CustomDevice, this));
				}
				return result;
			}
			set
			{
				this.CustomDevice.CopyAssign(value);
			}
		}

		// Token: 0x0601F6DD RID: 128733 RVA: 0x002EAE8F File Offset: 0x002E908F
		static ULGUIMobileFontAtlasTextureSizeWhiteList()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIMobileFontAtlasTextureSizeWhiteList");
		}

		// Token: 0x0601F6DE RID: 128734 RVA: 0x002EAE9D File Offset: 0x002E909D
		protected ULGUIMobileFontAtlasTextureSizeWhiteList(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F98 RID: 69528
		public new const string __ObjectPath = "/Script/LGUI.LGUIMobileFontAtlasTextureSizeWhiteList";

		// Token: 0x04010F99 RID: 69529
		private static IntPtr _ClassPtr;

		// Token: 0x04010F9A RID: 69530
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F9B RID: 69531
		internal static int __PropertyOffset_CustomDevice;

		// Token: 0x04010F9C RID: 69532
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _CustomDevice;
	}
}
