using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200214D RID: 8525
	[UnrealObjectPath("/Script/LGUI.UIEffectRenderable")]
	[UnrealStructLayout(2192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2192)]
	public class UUIEffectRenderable : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020248 RID: 131656 RVA: 0x002FC62B File Offset: 0x002FA82B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectRenderable._ClassPtr;
		}

		// Token: 0x06020249 RID: 131657 RVA: 0x002FC638 File Offset: 0x002FA838
		public UUIEffectRenderable() : this(BuiltinUtils.AllocNativeUObject(UUIEffectRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602024A RID: 131658 RVA: 0x002FC660 File Offset: 0x002FA860
		[NullableContext(1)]
		public UUIEffectRenderable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectRenderable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602024B RID: 131659 RVA: 0x002FC693 File Offset: 0x002FA893
		static UUIEffectRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectRenderable");
		}

		// Token: 0x0602024C RID: 131660 RVA: 0x002FC6A1 File Offset: 0x002FA8A1
		protected UUIEffectRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114A2 RID: 70818
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectRenderable";

		// Token: 0x040114A3 RID: 70819
		private static IntPtr _ClassPtr;

		// Token: 0x040114A4 RID: 70820
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
