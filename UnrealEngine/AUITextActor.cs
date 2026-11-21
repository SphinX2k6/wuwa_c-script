using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072E RID: 1838
	[UnrealObjectPath("/Script/LGUI.UITextActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUITextActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A048 RID: 41032 RVA: 0x000ED54C File Offset: 0x000EB74C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUITextActor._ClassPtr;
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x000ED558 File Offset: 0x000EB758
		public AUITextActor() : this(BuiltinUtils.AllocNativeUObject(AUITextActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x000ED580 File Offset: 0x000EB780
		[NullableContext(1)]
		public AUITextActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUITextActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x0600A04B RID: 41035 RVA: 0x000ED5B3 File Offset: 0x000EB7B3
		// (set) Token: 0x0600A04C RID: 41036 RVA: 0x000ED5C7 File Offset: 0x000EB7C7
		[Nullable(2)]
		public unsafe UUIText UIText
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIText>(base.NativePtr / (IntPtr)sizeof(void*) + AUITextActor.__PropertyOffset_UIText);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUITextActor.__PropertyOffset_UIText, value);
			}
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x000ED5DC File Offset: 0x000EB7DC
		static AUITextActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextActor");
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x000ED5EA File Offset: 0x000EB7EA
		protected AUITextActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400449F RID: 17567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextActor";

		// Token: 0x040044A0 RID: 17568
		private static IntPtr _ClassPtr;

		// Token: 0x040044A1 RID: 17569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040044A2 RID: 17570
		internal static int __PropertyOffset_UIText;
	}
}
