using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001718 RID: 5912
	[UnrealObjectPath("/Script/KuroBullet.ActionUpdateBulletPTT")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UActionUpdateBulletPTT : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015522 RID: 87330 RVA: 0x001F565E File Offset: 0x001F385E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateBulletPTT._ClassPtr;
		}

		// Token: 0x06015523 RID: 87331 RVA: 0x001F566C File Offset: 0x001F386C
		public UActionUpdateBulletPTT() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateBulletPTT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015524 RID: 87332 RVA: 0x001F5694 File Offset: 0x001F3894
		[NullableContext(1)]
		public UActionUpdateBulletPTT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateBulletPTT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015525 RID: 87333 RVA: 0x001F56C7 File Offset: 0x001F38C7
		static UActionUpdateBulletPTT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionUpdateBulletPTT");
		}

		// Token: 0x06015526 RID: 87334 RVA: 0x001F56D5 File Offset: 0x001F38D5
		protected UActionUpdateBulletPTT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9F0 RID: 47600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionUpdateBulletPTT";

		// Token: 0x0400B9F1 RID: 47601
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9F2 RID: 47602
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
