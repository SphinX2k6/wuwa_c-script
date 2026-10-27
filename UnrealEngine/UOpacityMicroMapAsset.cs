using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200261F RID: 9759
	[UnrealObjectPath("/Script/OpacityMicroMap.OpacityMicroMapAsset")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UOpacityMicroMapAsset : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024489 RID: 148617 RVA: 0x0035B7FF File Offset: 0x003599FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityMicroMapAsset._ClassPtr;
		}

		// Token: 0x0602448A RID: 148618 RVA: 0x0035B80C File Offset: 0x00359A0C
		public UOpacityMicroMapAsset() : this(BuiltinUtils.AllocNativeUObject(UOpacityMicroMapAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602448B RID: 148619 RVA: 0x0035B834 File Offset: 0x00359A34
		[NullableContext(1)]
		public UOpacityMicroMapAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityMicroMapAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008BB3 RID: 35763
		// (get) Token: 0x0602448C RID: 148620 RVA: 0x0035B867 File Offset: 0x00359A67
		// (set) Token: 0x0602448D RID: 148621 RVA: 0x0035B87B File Offset: 0x00359A7B
		[Nullable(2)]
		public unsafe UOpacityMicroMapCollection Collection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UOpacityMicroMapCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UOpacityMicroMapAsset.__PropertyOffset_Collection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UOpacityMicroMapAsset.__PropertyOffset_Collection, value);
			}
		}

		// Token: 0x0602448E RID: 148622 RVA: 0x0035B890 File Offset: 0x00359A90
		static UOpacityMicroMapAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpacityMicroMap.OpacityMicroMapAsset");
		}

		// Token: 0x0602448F RID: 148623 RVA: 0x0035B89E File Offset: 0x00359A9E
		protected UOpacityMicroMapAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013769 RID: 79721
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OpacityMicroMap.OpacityMicroMapAsset";

		// Token: 0x0401376A RID: 79722
		private static IntPtr _ClassPtr;

		// Token: 0x0401376B RID: 79723
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401376C RID: 79724
		internal static int __PropertyOffset_Collection;
	}
}
