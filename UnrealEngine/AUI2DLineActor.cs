using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002119 RID: 8473
	[UnrealObjectPath("/Script/LGUI.UI2DLineActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUI2DLineActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE18 RID: 130584 RVA: 0x002F6F17 File Offset: 0x002F5117
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUI2DLineActor._ClassPtr;
		}

		// Token: 0x0601FE19 RID: 130585 RVA: 0x002F6F24 File Offset: 0x002F5124
		public AUI2DLineActor() : this(BuiltinUtils.AllocNativeUObject(AUI2DLineActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE1A RID: 130586 RVA: 0x002F6F4C File Offset: 0x002F514C
		[NullableContext(1)]
		public AUI2DLineActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUI2DLineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D64 RID: 32100
		// (get) Token: 0x0601FE1B RID: 130587 RVA: 0x002F6F7F File Offset: 0x002F517F
		// (set) Token: 0x0601FE1C RID: 130588 RVA: 0x002F6F93 File Offset: 0x002F5193
		[Nullable(2)]
		public unsafe UUI2DLineRaw UIElement
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUI2DLineRaw>(base.NativePtr / (IntPtr)sizeof(void*) + AUI2DLineActor.__PropertyOffset_UIElement);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUI2DLineActor.__PropertyOffset_UIElement, value);
			}
		}

		// Token: 0x0601FE1D RID: 130589 RVA: 0x002F6FA8 File Offset: 0x002F51A8
		static AUI2DLineActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UI2DLineActor");
		}

		// Token: 0x0601FE1E RID: 130590 RVA: 0x002F6FB6 File Offset: 0x002F51B6
		protected AUI2DLineActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112D8 RID: 70360
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UI2DLineActor";

		// Token: 0x040112D9 RID: 70361
		private static IntPtr _ClassPtr;

		// Token: 0x040112DA RID: 70362
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112DB RID: 70363
		internal static int __PropertyOffset_UIElement;
	}
}
