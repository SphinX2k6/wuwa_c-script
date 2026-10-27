using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E89 RID: 7817
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroTerrainSurvey.KTSPT_CopyPropertyData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKTSPT_CopyPropertyData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DBE7 RID: 121831 RVA: 0x002BF220 File Offset: 0x002BD420
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKTSPT_CopyPropertyData._ScriptStructPtr != 0) ? FKTSPT_CopyPropertyData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroTerrainSurvey.KTSPT_CopyPropertyData", ref FKTSPT_CopyPropertyData._ScriptStructPtr);
		}

		// Token: 0x1700777E RID: 30590
		// (get) Token: 0x0601DBE8 RID: 121832 RVA: 0x002BF244 File Offset: 0x002BD444
		// (set) Token: 0x0601DBE9 RID: 121833 RVA: 0x002BF287 File Offset: 0x002BD487
		public TArray<FName> InnerNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InnerNames) == null)
				{
					result = (this._InnerNames = new TArray<FName>(base.NativePtr + (IntPtr)FKTSPT_CopyPropertyData.__PropertyOffset_InnerNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InnerNames.CopyAssign(value);
			}
		}

		// Token: 0x0601DBEA RID: 121834 RVA: 0x002BF295 File Offset: 0x002BD495
		public FKTSPT_CopyPropertyData()
		{
		}

		// Token: 0x0601DBEB RID: 121835 RVA: 0x002BF29D File Offset: 0x002BD49D
		public FKTSPT_CopyPropertyData(TArray<FName> InnerNames)
		{
			this.InnerNames = InnerNames;
		}

		// Token: 0x0601DBEC RID: 121836 RVA: 0x002BF2AC File Offset: 0x002BD4AC
		protected override IntPtr GetUStructPtr()
		{
			return FKTSPT_CopyPropertyData.StaticStruct();
		}

		// Token: 0x0601DBED RID: 121837 RVA: 0x002BF2B8 File Offset: 0x002BD4B8
		[NullableContext(2)]
		public FKTSPT_CopyPropertyData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBEE RID: 121838 RVA: 0x002BF2C2 File Offset: 0x002BD4C2
		public FKTSPT_CopyPropertyData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBEF RID: 121839 RVA: 0x002BF2CD File Offset: 0x002BD4CD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKTSPT_CopyPropertyData(Pointer, false, true);
		}

		// Token: 0x0601DBF0 RID: 121840 RVA: 0x002BF2D7 File Offset: 0x002BD4D7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKTSPT_CopyPropertyData(Pointer, MemoryOwner);
		}

		// Token: 0x040101AF RID: 65967
		public const string __ObjectPath = "/Script/KuroTerrainSurvey.KTSPT_CopyPropertyData";

		// Token: 0x040101B0 RID: 65968
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040101B1 RID: 65969
		internal static int __PropertyOffset_InnerNames;

		// Token: 0x040101B2 RID: 65970
		[Nullable(2)]
		private TArray<FName> _InnerNames;
	}
}
