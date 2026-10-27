using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021CA RID: 8650
	[UnrealObjectPath("/Script/LGUI.UITextActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUITextActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F4B RID: 134987 RVA: 0x0030A27C File Offset: 0x0030847C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUITextActor._ClassPtr;
		}

		// Token: 0x06020F4C RID: 134988 RVA: 0x0030A288 File Offset: 0x00308488
		public AUITextActor() : this(BuiltinUtils.AllocNativeUObject(AUITextActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F4D RID: 134989 RVA: 0x0030A2B0 File Offset: 0x003084B0
		[NullableContext(1)]
		public AUITextActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUITextActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080A8 RID: 32936
		// (get) Token: 0x06020F4E RID: 134990 RVA: 0x0030A2E3 File Offset: 0x003084E3
		// (set) Token: 0x06020F4F RID: 134991 RVA: 0x0030A2F7 File Offset: 0x003084F7
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

		// Token: 0x06020F50 RID: 134992 RVA: 0x0030A30C File Offset: 0x0030850C
		static AUITextActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextActor");
		}

		// Token: 0x06020F51 RID: 134993 RVA: 0x0030A31A File Offset: 0x0030851A
		protected AUITextActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011968 RID: 72040
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextActor";

		// Token: 0x04011969 RID: 72041
		private static IntPtr _ClassPtr;

		// Token: 0x0401196A RID: 72042
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401196B RID: 72043
		internal static int __PropertyOffset_UIText;
	}
}
