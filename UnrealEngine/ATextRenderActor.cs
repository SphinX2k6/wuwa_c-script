using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011C9 RID: 4553
	[UnrealObjectPath("/Script/Engine.TextRenderActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ATextRenderActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010C55 RID: 68693 RVA: 0x0018A237 File Offset: 0x00188437
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATextRenderActor._ClassPtr;
		}

		// Token: 0x06010C56 RID: 68694 RVA: 0x0018A244 File Offset: 0x00188444
		public ATextRenderActor() : this(BuiltinUtils.AllocNativeUObject(ATextRenderActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010C57 RID: 68695 RVA: 0x0018A26C File Offset: 0x0018846C
		[NullableContext(1)]
		public ATextRenderActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATextRenderActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x06010C58 RID: 68696 RVA: 0x0018A29F File Offset: 0x0018849F
		// (set) Token: 0x06010C59 RID: 68697 RVA: 0x0018A2B3 File Offset: 0x001884B3
		[Nullable(2)]
		public unsafe UTextRenderComponent TextRender
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATextRenderActor.__PropertyOffset_TextRender);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATextRenderActor.__PropertyOffset_TextRender, value);
			}
		}

		// Token: 0x06010C5A RID: 68698 RVA: 0x0018A2C8 File Offset: 0x001884C8
		static ATextRenderActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextRenderActor");
		}

		// Token: 0x06010C5B RID: 68699 RVA: 0x0018A2D6 File Offset: 0x001884D6
		protected ATextRenderActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F69 RID: 36713
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextRenderActor";

		// Token: 0x04008F6A RID: 36714
		private static IntPtr _ClassPtr;

		// Token: 0x04008F6B RID: 36715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008F6C RID: 36716
		internal static int __PropertyOffset_TextRender;
	}
}
