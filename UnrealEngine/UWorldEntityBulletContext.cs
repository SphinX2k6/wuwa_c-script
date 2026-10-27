using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001737 RID: 5943
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.WorldEntityBulletContext")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UWorldEntityBulletContext : UCustomBulletContext, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015644 RID: 87620 RVA: 0x001F6E00 File Offset: 0x001F5000
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldEntityBulletContext._ClassPtr;
		}

		// Token: 0x06015645 RID: 87621 RVA: 0x001F6E0C File Offset: 0x001F500C
		public UWorldEntityBulletContext() : this(BuiltinUtils.AllocNativeUObject(UWorldEntityBulletContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015646 RID: 87622 RVA: 0x001F6E34 File Offset: 0x001F5034
		public UWorldEntityBulletContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldEntityBulletContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005484 RID: 21636
		// (get) Token: 0x06015647 RID: 87623 RVA: 0x001F6E68 File Offset: 0x001F5068
		// (set) Token: 0x06015648 RID: 87624 RVA: 0x001F6EA1 File Offset: 0x001F50A1
		public FWorldEntityBulletParam ExtraParam
		{
			get
			{
				base.FastCheckIsValid();
				FWorldEntityBulletParam result;
				if ((result = this._ExtraParam) == null)
				{
					result = (this._ExtraParam = new FWorldEntityBulletParam(base.NativePtr + (IntPtr)UWorldEntityBulletContext.__PropertyOffset_ExtraParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldEntityBulletParam.StaticStruct(), base.NativePtr + (IntPtr)UWorldEntityBulletContext.__PropertyOffset_ExtraParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06015649 RID: 87625 RVA: 0x001F6EC2 File Offset: 0x001F50C2
		static UWorldEntityBulletContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.WorldEntityBulletContext");
		}

		// Token: 0x0601564A RID: 87626 RVA: 0x001F6ED0 File Offset: 0x001F50D0
		protected UWorldEntityBulletContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BAA5 RID: 47781
		public new const string __ObjectPath = "/Script/KuroBullet.WorldEntityBulletContext";

		// Token: 0x0400BAA6 RID: 47782
		private static IntPtr _ClassPtr;

		// Token: 0x0400BAA7 RID: 47783
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BAA8 RID: 47784
		internal static int __PropertyOffset_ExtraParam;

		// Token: 0x0400BAA9 RID: 47785
		[Nullable(2)]
		private FWorldEntityBulletParam _ExtraParam;
	}
}
