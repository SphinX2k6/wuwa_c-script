using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002122 RID: 8482
	[UnrealObjectPath("/Script/LGUI.UIArtTextActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIArtTextActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE9A RID: 130714 RVA: 0x002F7757 File Offset: 0x002F5957
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIArtTextActor._ClassPtr;
		}

		// Token: 0x0601FE9B RID: 130715 RVA: 0x002F7764 File Offset: 0x002F5964
		public AUIArtTextActor() : this(BuiltinUtils.AllocNativeUObject(AUIArtTextActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE9C RID: 130716 RVA: 0x002F778C File Offset: 0x002F598C
		[NullableContext(1)]
		public AUIArtTextActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIArtTextActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D77 RID: 32119
		// (get) Token: 0x0601FE9D RID: 130717 RVA: 0x002F77BF File Offset: 0x002F59BF
		// (set) Token: 0x0601FE9E RID: 130718 RVA: 0x002F77D3 File Offset: 0x002F59D3
		[Nullable(2)]
		public unsafe UUIArtText UIArtText
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIArtText>(base.NativePtr / (IntPtr)sizeof(void*) + AUIArtTextActor.__PropertyOffset_UIArtText);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIArtTextActor.__PropertyOffset_UIArtText, value);
			}
		}

		// Token: 0x0601FE9F RID: 130719 RVA: 0x002F77E8 File Offset: 0x002F59E8
		static AUIArtTextActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIArtTextActor");
		}

		// Token: 0x0601FEA0 RID: 130720 RVA: 0x002F77F6 File Offset: 0x002F59F6
		protected AUIArtTextActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011313 RID: 70419
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIArtTextActor";

		// Token: 0x04011314 RID: 70420
		private static IntPtr _ClassPtr;

		// Token: 0x04011315 RID: 70421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011316 RID: 70422
		internal static int __PropertyOffset_UIArtText;
	}
}
