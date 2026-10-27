using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002977 RID: 10615
	[UnrealObjectPath("/Script/UMG.HorizontalBox")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UHorizontalBox : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027425 RID: 160805 RVA: 0x003BDE57 File Offset: 0x003BC057
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHorizontalBox._ClassPtr;
		}

		// Token: 0x06027426 RID: 160806 RVA: 0x003BDE64 File Offset: 0x003BC064
		public UHorizontalBox() : this(BuiltinUtils.AllocNativeUObject(UHorizontalBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027427 RID: 160807 RVA: 0x003BDE8C File Offset: 0x003BC08C
		[NullableContext(1)]
		public UHorizontalBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHorizontalBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027428 RID: 160808 RVA: 0x003BDEBF File Offset: 0x003BC0BF
		[NullableContext(2)]
		public UHorizontalBoxSlot AddChildToHorizontalBox(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UHorizontalBoxSlot>(UHorizontalBox.__AddChildToHorizontalBox_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027429 RID: 160809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToHorizontalBox_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0602742A RID: 160810 RVA: 0x003BDEE1 File Offset: 0x003BC0E1
		static UHorizontalBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.HorizontalBox");
		}

		// Token: 0x0602742B RID: 160811 RVA: 0x003BDEEF File Offset: 0x003BC0EF
		protected UHorizontalBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015918 RID: 88344
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.HorizontalBox";

		// Token: 0x04015919 RID: 88345
		private static IntPtr _ClassPtr;

		// Token: 0x0401591A RID: 88346
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
