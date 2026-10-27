using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200093F RID: 2367
	[UnrealObjectPath("/Script/Engine.CollectionParameterBase")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FCollectionParameterBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060085DB RID: 34267 RVA: 0x000BED3B File Offset: 0x000BCF3B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollectionParameterBase._ScriptStructPtr != 0) ? FCollectionParameterBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollectionParameterBase", ref FCollectionParameterBase._ScriptStructPtr);
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x000BED5F File Offset: 0x000BCF5F
		// (set) Token: 0x060085DD RID: 34269 RVA: 0x000BED73 File Offset: 0x000BCF73
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollectionParameterBase.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollectionParameterBase.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x060085DE RID: 34270 RVA: 0x000BED88 File Offset: 0x000BCF88
		// (set) Token: 0x060085DF RID: 34271 RVA: 0x000BED9C File Offset: 0x000BCF9C
		public unsafe FGuid Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollectionParameterBase.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollectionParameterBase.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x060085E0 RID: 34272 RVA: 0x000BEDB1 File Offset: 0x000BCFB1
		public FCollectionParameterBase()
		{
		}

		// Token: 0x060085E1 RID: 34273 RVA: 0x000BEDB9 File Offset: 0x000BCFB9
		public FCollectionParameterBase(FName ParameterName, FGuid Id)
		{
			this.ParameterName = ParameterName;
			this.Id = Id;
		}

		// Token: 0x060085E2 RID: 34274 RVA: 0x000BEDCF File Offset: 0x000BCFCF
		protected override IntPtr GetUStructPtr()
		{
			return FCollectionParameterBase.StaticStruct();
		}

		// Token: 0x060085E3 RID: 34275 RVA: 0x000BEDDB File Offset: 0x000BCFDB
		[NullableContext(2)]
		public FCollectionParameterBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060085E4 RID: 34276 RVA: 0x000BEDE5 File Offset: 0x000BCFE5
		public FCollectionParameterBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x000BEDF0 File Offset: 0x000BCFF0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollectionParameterBase(Pointer, false, true);
		}

		// Token: 0x060085E6 RID: 34278 RVA: 0x000BEDFA File Offset: 0x000BCFFA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollectionParameterBase(Pointer, MemoryOwner);
		}

		// Token: 0x04003FB2 RID: 16306
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CollectionParameterBase";

		// Token: 0x04003FB3 RID: 16307
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FB4 RID: 16308
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04003FB5 RID: 16309
		internal static int __PropertyOffset_Id;
	}
}
