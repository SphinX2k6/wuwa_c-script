using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000934 RID: 2356
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ClientEntityAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UClientEntityAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008529 RID: 34089 RVA: 0x000BDE80 File Offset: 0x000BC080
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClientEntityAsset._ClassPtr;
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x000BDE8C File Offset: 0x000BC08C
		public UClientEntityAsset() : this(BuiltinUtils.AllocNativeUObject(UClientEntityAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600852B RID: 34091 RVA: 0x000BDEB4 File Offset: 0x000BC0B4
		public UClientEntityAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClientEntityAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x0600852C RID: 34092 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		// (set) Token: 0x0600852D RID: 34093 RVA: 0x000BDF21 File Offset: 0x000BC121
		public TArray<FClientEntityPackData> PackDatas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FClientEntityPackData> result;
				if ((result = this._PackDatas) == null)
				{
					result = (this._PackDatas = new TArray<FClientEntityPackData>(base.NativePtr + (IntPtr)UClientEntityAsset.__PropertyOffset_PackDatas, this));
				}
				return result;
			}
			set
			{
				this.PackDatas.CopyAssign(value);
			}
		}

		// Token: 0x0600852E RID: 34094 RVA: 0x000BDF2F File Offset: 0x000BC12F
		static UClientEntityAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ClientEntityAsset");
		}

		// Token: 0x0600852F RID: 34095 RVA: 0x000BDF3D File Offset: 0x000BC13D
		protected UClientEntityAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F5D RID: 16221
		public new const string __ObjectPath = "/Script/Engine.ClientEntityAsset";

		// Token: 0x04003F5E RID: 16222
		private static IntPtr _ClassPtr;

		// Token: 0x04003F5F RID: 16223
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F60 RID: 16224
		internal static int __PropertyOffset_PackDatas;

		// Token: 0x04003F61 RID: 16225
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FClientEntityPackData> _PackDatas;
	}
}
