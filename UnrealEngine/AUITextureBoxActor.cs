using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D8 RID: 8664
	[UnrealObjectPath("/Script/LGUI.UITextureBoxActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUITextureBoxActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602104E RID: 135246 RVA: 0x0030B611 File Offset: 0x00309811
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUITextureBoxActor._ClassPtr;
		}

		// Token: 0x0602104F RID: 135247 RVA: 0x0030B620 File Offset: 0x00309820
		public AUITextureBoxActor() : this(BuiltinUtils.AllocNativeUObject(AUITextureBoxActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021050 RID: 135248 RVA: 0x0030B648 File Offset: 0x00309848
		[NullableContext(1)]
		public AUITextureBoxActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUITextureBoxActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080E3 RID: 32995
		// (get) Token: 0x06021051 RID: 135249 RVA: 0x0030B67B File Offset: 0x0030987B
		// (set) Token: 0x06021052 RID: 135250 RVA: 0x0030B68F File Offset: 0x0030988F
		[Nullable(2)]
		public unsafe UUITextureBox UITextureBox
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUITextureBox>(base.NativePtr / (IntPtr)sizeof(void*) + AUITextureBoxActor.__PropertyOffset_UITextureBox);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUITextureBoxActor.__PropertyOffset_UITextureBox, value);
			}
		}

		// Token: 0x06021053 RID: 135251 RVA: 0x0030B6A4 File Offset: 0x003098A4
		static AUITextureBoxActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureBoxActor");
		}

		// Token: 0x06021054 RID: 135252 RVA: 0x0030B6B2 File Offset: 0x003098B2
		protected AUITextureBoxActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119E9 RID: 72169
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureBoxActor";

		// Token: 0x040119EA RID: 72170
		private static IntPtr _ClassPtr;

		// Token: 0x040119EB RID: 72171
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119EC RID: 72172
		internal static int __PropertyOffset_UITextureBox;
	}
}
