using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B44 RID: 6980
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_DitherConst")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FKuroMaterialControllerParam_DitherConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A6DD RID: 108253 RVA: 0x0026F783 File Offset: 0x0026D983
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_DitherConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_DitherConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_DitherConst", ref FKuroMaterialControllerParam_DitherConst._ScriptStructPtr);
		}

		// Token: 0x17006A42 RID: 27202
		// (get) Token: 0x0601A6DE RID: 108254 RVA: 0x0026F7A7 File Offset: 0x0026D9A7
		// (set) Token: 0x0601A6DF RID: 108255 RVA: 0x0026F7B7 File Offset: 0x0026D9B7
		public unsafe float DitherValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DitherConst.__PropertyOffset_DitherValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_DitherConst.__PropertyOffset_DitherValue) = value;
			}
		}

		// Token: 0x0601A6E0 RID: 108256 RVA: 0x0026F7C8 File Offset: 0x0026D9C8
		public FKuroMaterialControllerParam_DitherConst()
		{
		}

		// Token: 0x0601A6E1 RID: 108257 RVA: 0x0026F7D0 File Offset: 0x0026D9D0
		public FKuroMaterialControllerParam_DitherConst(float DitherValue)
		{
			this.DitherValue = DitherValue;
		}

		// Token: 0x0601A6E2 RID: 108258 RVA: 0x0026F7DF File Offset: 0x0026D9DF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_DitherConst.StaticStruct();
		}

		// Token: 0x0601A6E3 RID: 108259 RVA: 0x0026F7EB File Offset: 0x0026D9EB
		[NullableContext(2)]
		public FKuroMaterialControllerParam_DitherConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A6E4 RID: 108260 RVA: 0x0026F7F5 File Offset: 0x0026D9F5
		public FKuroMaterialControllerParam_DitherConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A6E5 RID: 108261 RVA: 0x0026F800 File Offset: 0x0026DA00
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_DitherConst(Pointer, false, true);
		}

		// Token: 0x0601A6E6 RID: 108262 RVA: 0x0026F80A File Offset: 0x0026DA0A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_DitherConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E522 RID: 58658
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_DitherConst";

		// Token: 0x0400E523 RID: 58659
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E524 RID: 58660
		internal static int __PropertyOffset_DitherValue;
	}
}
