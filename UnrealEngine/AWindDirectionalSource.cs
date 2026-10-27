using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001247 RID: 4679
	[UnrealObjectPath("/Script/Engine.WindDirectionalSource")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AWindDirectionalSource : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601131A RID: 70426 RVA: 0x001939F8 File Offset: 0x00191BF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWindDirectionalSource._ClassPtr;
		}

		// Token: 0x0601131B RID: 70427 RVA: 0x00193A04 File Offset: 0x00191C04
		public AWindDirectionalSource() : this(BuiltinUtils.AllocNativeUObject(AWindDirectionalSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601131C RID: 70428 RVA: 0x00193A2C File Offset: 0x00191C2C
		[NullableContext(1)]
		public AWindDirectionalSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWindDirectionalSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004302 RID: 17154
		// (get) Token: 0x0601131D RID: 70429 RVA: 0x00193A5F File Offset: 0x00191C5F
		// (set) Token: 0x0601131E RID: 70430 RVA: 0x00193A73 File Offset: 0x00191C73
		[Nullable(2)]
		public unsafe UWindDirectionalSourceComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWindDirectionalSourceComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AWindDirectionalSource.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWindDirectionalSource.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x0601131F RID: 70431 RVA: 0x00193A88 File Offset: 0x00191C88
		static AWindDirectionalSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WindDirectionalSource");
		}

		// Token: 0x06011320 RID: 70432 RVA: 0x00193A96 File Offset: 0x00191C96
		protected AWindDirectionalSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400931C RID: 37660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WindDirectionalSource";

		// Token: 0x0400931D RID: 37661
		private static IntPtr _ClassPtr;

		// Token: 0x0400931E RID: 37662
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400931F RID: 37663
		internal static int __PropertyOffset_Component;
	}
}
