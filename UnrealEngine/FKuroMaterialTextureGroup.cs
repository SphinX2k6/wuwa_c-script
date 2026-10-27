using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B70 RID: 7024
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialTextureGroup")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroMaterialTextureGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A946 RID: 108870 RVA: 0x00273100 File Offset: 0x00271300
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialTextureGroup._ScriptStructPtr != 0) ? FKuroMaterialTextureGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialTextureGroup", ref FKuroMaterialTextureGroup._ScriptStructPtr);
		}

		// Token: 0x17006AC9 RID: 27337
		// (get) Token: 0x0601A947 RID: 108871 RVA: 0x00273124 File Offset: 0x00271324
		// (set) Token: 0x0601A948 RID: 108872 RVA: 0x00273138 File Offset: 0x00271338
		public unsafe UTexture StartValue
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialTextureGroup.__PropertyOffset_StartValue);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialTextureGroup.__PropertyOffset_StartValue, value);
			}
		}

		// Token: 0x17006ACA RID: 27338
		// (get) Token: 0x0601A949 RID: 108873 RVA: 0x0027314D File Offset: 0x0027134D
		// (set) Token: 0x0601A94A RID: 108874 RVA: 0x00273161 File Offset: 0x00271361
		public unsafe UTexture LoopValue
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialTextureGroup.__PropertyOffset_LoopValue);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialTextureGroup.__PropertyOffset_LoopValue, value);
			}
		}

		// Token: 0x17006ACB RID: 27339
		// (get) Token: 0x0601A94B RID: 108875 RVA: 0x00273176 File Offset: 0x00271376
		// (set) Token: 0x0601A94C RID: 108876 RVA: 0x0027318A File Offset: 0x0027138A
		public unsafe UTexture EndValue
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialTextureGroup.__PropertyOffset_EndValue);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialTextureGroup.__PropertyOffset_EndValue, value);
			}
		}

		// Token: 0x0601A94D RID: 108877 RVA: 0x0027319F File Offset: 0x0027139F
		public FKuroMaterialTextureGroup()
		{
		}

		// Token: 0x0601A94E RID: 108878 RVA: 0x002731A7 File Offset: 0x002713A7
		[NullableContext(1)]
		public FKuroMaterialTextureGroup(UTexture StartValue, UTexture LoopValue, UTexture EndValue)
		{
			this.StartValue = StartValue;
			this.LoopValue = LoopValue;
			this.EndValue = EndValue;
		}

		// Token: 0x0601A94F RID: 108879 RVA: 0x002731C4 File Offset: 0x002713C4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialTextureGroup.StaticStruct();
		}

		// Token: 0x0601A950 RID: 108880 RVA: 0x002731D0 File Offset: 0x002713D0
		public FKuroMaterialTextureGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A951 RID: 108881 RVA: 0x002731DA File Offset: 0x002713DA
		public FKuroMaterialTextureGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A952 RID: 108882 RVA: 0x002731E5 File Offset: 0x002713E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialTextureGroup(Pointer, false, true);
		}

		// Token: 0x0601A953 RID: 108883 RVA: 0x002731EF File Offset: 0x002713EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialTextureGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400E641 RID: 58945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialTextureGroup";

		// Token: 0x0400E642 RID: 58946
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E643 RID: 58947
		internal static int __PropertyOffset_StartValue;

		// Token: 0x0400E644 RID: 58948
		internal static int __PropertyOffset_LoopValue;

		// Token: 0x0400E645 RID: 58949
		internal static int __PropertyOffset_EndValue;
	}
}
