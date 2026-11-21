using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000174 RID: 372
	[UnrealObjectPath("/Script/Engine.AlphaBlend")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAlphaBlend : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060016B4 RID: 5812 RVA: 0x0002371A File Offset: 0x0002191A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAlphaBlend._ScriptStructPtr != 0) ? FAlphaBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AlphaBlend", ref FAlphaBlend._ScriptStructPtr);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0002373E File Offset: 0x0002193E
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x00023752 File Offset: 0x00021952
		[Nullable(2)]
		public unsafe UCurveFloat CustomCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAlphaBlend.__PropertyOffset_CustomCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAlphaBlend.__PropertyOffset_CustomCurve, value);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x00023767 File Offset: 0x00021967
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00023777 File Offset: 0x00021977
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAlphaBlend.__PropertyOffset_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAlphaBlend.__PropertyOffset_BlendTime) = value;
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00023788 File Offset: 0x00021988
		public FAlphaBlend()
		{
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00023790 File Offset: 0x00021990
		protected override IntPtr GetUStructPtr()
		{
			return FAlphaBlend.StaticStruct();
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0002379C File Offset: 0x0002199C
		[NullableContext(2)]
		public FAlphaBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000237A6 File Offset: 0x000219A6
		public FAlphaBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000237B1 File Offset: 0x000219B1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAlphaBlend(Pointer, false, true);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000237BB File Offset: 0x000219BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAlphaBlend(Pointer, MemoryOwner);
		}

		// Token: 0x04000739 RID: 1849
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AlphaBlend";

		// Token: 0x0400073A RID: 1850
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400073B RID: 1851
		internal static int __PropertyOffset_CustomCurve;

		// Token: 0x0400073C RID: 1852
		internal static int __PropertyOffset_BlendTime;
	}
}
