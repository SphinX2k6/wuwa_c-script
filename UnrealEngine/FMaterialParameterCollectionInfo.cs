using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E92 RID: 3730
	[UnrealObjectPath("/Script/Engine.MaterialParameterCollectionInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMaterialParameterCollectionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C8AB RID: 51371 RVA: 0x0012422E File Offset: 0x0012242E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialParameterCollectionInfo._ScriptStructPtr != 0) ? FMaterialParameterCollectionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialParameterCollectionInfo", ref FMaterialParameterCollectionInfo._ScriptStructPtr);
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x0600C8AC RID: 51372 RVA: 0x00124252 File Offset: 0x00122452
		// (set) Token: 0x0600C8AD RID: 51373 RVA: 0x00124266 File Offset: 0x00122466
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialParameterCollectionInfo.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialParameterCollectionInfo.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x0600C8AE RID: 51374 RVA: 0x0012427B File Offset: 0x0012247B
		// (set) Token: 0x0600C8AF RID: 51375 RVA: 0x0012428F File Offset: 0x0012248F
		[Nullable(2)]
		public unsafe UMaterialParameterCollection ParameterCollection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialParameterCollectionInfo.__PropertyOffset_ParameterCollection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialParameterCollectionInfo.__PropertyOffset_ParameterCollection, value);
			}
		}

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x001242A4 File Offset: 0x001224A4
		public FMaterialParameterCollectionInfo()
		{
		}

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x001242AC File Offset: 0x001224AC
		[NullableContext(1)]
		public FMaterialParameterCollectionInfo(FGuid StateId, UMaterialParameterCollection ParameterCollection)
		{
			this.StateId = StateId;
			this.ParameterCollection = ParameterCollection;
		}

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x001242C2 File Offset: 0x001224C2
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialParameterCollectionInfo.StaticStruct();
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x001242CE File Offset: 0x001224CE
		[NullableContext(2)]
		public FMaterialParameterCollectionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x001242D8 File Offset: 0x001224D8
		public FMaterialParameterCollectionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C8B5 RID: 51381 RVA: 0x001242E3 File Offset: 0x001224E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialParameterCollectionInfo(Pointer, false, true);
		}

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x001242ED File Offset: 0x001224ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialParameterCollectionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006BFD RID: 27645
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialParameterCollectionInfo";

		// Token: 0x04006BFE RID: 27646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006BFF RID: 27647
		internal static int __PropertyOffset_StateId;

		// Token: 0x04006C00 RID: 27648
		internal static int __PropertyOffset_ParameterCollection;
	}
}
