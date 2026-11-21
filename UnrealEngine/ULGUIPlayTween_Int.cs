using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006AE RID: 1710
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Int")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUIPlayTween_Int : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092D6 RID: 37590 RVA: 0x000DD2AC File Offset: 0x000DB4AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Int._ClassPtr;
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x000DD2B8 File Offset: 0x000DB4B8
		public ULGUIPlayTween_Int() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Int.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x000DD2E0 File Offset: 0x000DB4E0
		[NullableContext(1)]
		public ULGUIPlayTween_Int(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Int.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x060092D9 RID: 37593 RVA: 0x000DD313 File Offset: 0x000DB513
		// (set) Token: 0x060092DA RID: 37594 RVA: 0x000DD323 File Offset: 0x000DB523
		public unsafe int from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x060092DB RID: 37595 RVA: 0x000DD334 File Offset: 0x000DB534
		// (set) Token: 0x060092DC RID: 37596 RVA: 0x000DD344 File Offset: 0x000DB544
		public unsafe int to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x000DD355 File Offset: 0x000DB555
		static ULGUIPlayTween_Int()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Int");
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x000DD363 File Offset: 0x000DB563
		protected ULGUIPlayTween_Int(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003FFF RID: 16383
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Int";

		// Token: 0x04004000 RID: 16384
		private static IntPtr _ClassPtr;

		// Token: 0x04004001 RID: 16385
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004002 RID: 16386
		internal static int __PropertyOffset_from;

		// Token: 0x04004003 RID: 16387
		internal static int __PropertyOffset_to;
	}
}
