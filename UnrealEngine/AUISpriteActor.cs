using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021BA RID: 8634
	[UnrealObjectPath("/Script/LGUI.UISpriteActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUISpriteActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020DD3 RID: 134611 RVA: 0x00308BCC File Offset: 0x00306DCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUISpriteActor._ClassPtr;
		}

		// Token: 0x06020DD4 RID: 134612 RVA: 0x00308BD8 File Offset: 0x00306DD8
		public AUISpriteActor() : this(BuiltinUtils.AllocNativeUObject(AUISpriteActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020DD5 RID: 134613 RVA: 0x00308C00 File Offset: 0x00306E00
		[NullableContext(1)]
		public AUISpriteActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUISpriteActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700805F RID: 32863
		// (get) Token: 0x06020DD6 RID: 134614 RVA: 0x00308C33 File Offset: 0x00306E33
		// (set) Token: 0x06020DD7 RID: 134615 RVA: 0x00308C47 File Offset: 0x00306E47
		[Nullable(2)]
		public unsafe UUISprite UISprite
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUISprite>(base.NativePtr / (IntPtr)sizeof(void*) + AUISpriteActor.__PropertyOffset_UISprite);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUISpriteActor.__PropertyOffset_UISprite, value);
			}
		}

		// Token: 0x06020DD8 RID: 134616 RVA: 0x00308C5C File Offset: 0x00306E5C
		static AUISpriteActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteActor");
		}

		// Token: 0x06020DD9 RID: 134617 RVA: 0x00308C6A File Offset: 0x00306E6A
		protected AUISpriteActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118CE RID: 71886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteActor";

		// Token: 0x040118CF RID: 71887
		private static IntPtr _ClassPtr;

		// Token: 0x040118D0 RID: 71888
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040118D1 RID: 71889
		internal static int __PropertyOffset_UISprite;
	}
}
