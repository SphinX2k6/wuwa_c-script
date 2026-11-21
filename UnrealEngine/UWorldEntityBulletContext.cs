using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000337 RID: 823
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.WorldEntityBulletContext")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UWorldEntityBulletContext : UCustomBulletContext, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600558C RID: 21900 RVA: 0x000779FC File Offset: 0x00075BFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldEntityBulletContext._ClassPtr;
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x00077A08 File Offset: 0x00075C08
		public UWorldEntityBulletContext() : this(BuiltinUtils.AllocNativeUObject(UWorldEntityBulletContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00077A30 File Offset: 0x00075C30
		public UWorldEntityBulletContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldEntityBulletContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x0600558F RID: 21903 RVA: 0x00077A64 File Offset: 0x00075C64
		// (set) Token: 0x06005590 RID: 21904 RVA: 0x00077A9D File Offset: 0x00075C9D
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

		// Token: 0x06005591 RID: 21905 RVA: 0x00077ABE File Offset: 0x00075CBE
		static UWorldEntityBulletContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.WorldEntityBulletContext");
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00077ACC File Offset: 0x00075CCC
		protected UWorldEntityBulletContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022F6 RID: 8950
		public new const string __ObjectPath = "/Script/KuroBullet.WorldEntityBulletContext";

		// Token: 0x040022F7 RID: 8951
		private static IntPtr _ClassPtr;

		// Token: 0x040022F8 RID: 8952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040022F9 RID: 8953
		internal static int __PropertyOffset_ExtraParam;

		// Token: 0x040022FA RID: 8954
		[Nullable(2)]
		private FWorldEntityBulletParam _ExtraParam;
	}
}
