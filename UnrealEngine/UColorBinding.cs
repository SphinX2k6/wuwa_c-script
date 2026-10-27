using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002947 RID: 10567
	[UnrealObjectPath("/Script/UMG.ColorBinding")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UColorBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060271E7 RID: 160231 RVA: 0x003BA4C4 File Offset: 0x003B86C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UColorBinding._ClassPtr;
		}

		// Token: 0x060271E8 RID: 160232 RVA: 0x003BA4D0 File Offset: 0x003B86D0
		public UColorBinding() : this(BuiltinUtils.AllocNativeUObject(UColorBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060271E9 RID: 160233 RVA: 0x003BA4F8 File Offset: 0x003B86F8
		[NullableContext(1)]
		public UColorBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UColorBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060271EA RID: 160234 RVA: 0x003BA52B File Offset: 0x003B872B
		[NullableContext(1)]
		public FSlateColor GetSlateValue()
		{
			return new FSlateColor(UColorBinding.__GetSlateValue_Internal(base.NativePtr), null);
		}

		// Token: 0x060271EB RID: 160235 RVA: 0x003BA53E File Offset: 0x003B873E
		public FLinearColor GetLinearValue()
		{
			return UColorBinding.__GetLinearValue_Internal(base.NativePtr);
		}

		// Token: 0x060271EC RID: 160236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSlateValue_Internal(IntPtr @this);

		// Token: 0x060271ED RID: 160237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLinearValue_Internal(IntPtr @this);

		// Token: 0x060271EE RID: 160238 RVA: 0x003BA54B File Offset: 0x003B874B
		static UColorBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ColorBinding");
		}

		// Token: 0x060271EF RID: 160239 RVA: 0x003BA559 File Offset: 0x003B8759
		protected UColorBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157BE RID: 87998
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ColorBinding";

		// Token: 0x040157BF RID: 87999
		private static IntPtr _ClassPtr;

		// Token: 0x040157C0 RID: 88000
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
