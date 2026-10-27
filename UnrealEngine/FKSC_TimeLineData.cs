using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E59 RID: 7769
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_TimeLineData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKSC_TimeLineData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D959 RID: 121177 RVA: 0x002BAE05 File Offset: 0x002B9005
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_TimeLineData._ScriptStructPtr != 0) ? FKSC_TimeLineData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_TimeLineData", ref FKSC_TimeLineData._ScriptStructPtr);
		}

		// Token: 0x17007736 RID: 30518
		// (get) Token: 0x0601D95A RID: 121178 RVA: 0x002BAE29 File Offset: 0x002B9029
		// (set) Token: 0x0601D95B RID: 121179 RVA: 0x002BAE39 File Offset: 0x002B9039
		public unsafe float MaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_TimeLineData.__PropertyOffset_MaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_TimeLineData.__PropertyOffset_MaxTime) = value;
			}
		}

		// Token: 0x17007737 RID: 30519
		// (get) Token: 0x0601D95C RID: 121180 RVA: 0x002BAE4C File Offset: 0x002B904C
		// (set) Token: 0x0601D95D RID: 121181 RVA: 0x002BAE8F File Offset: 0x002B908F
		public TArray<FKSC_Delay_KuroFX> TimeLineFX
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_Delay_KuroFX> result;
				if ((result = this._TimeLineFX) == null)
				{
					result = (this._TimeLineFX = new TArray<FKSC_Delay_KuroFX>(base.NativePtr + (IntPtr)FKSC_TimeLineData.__PropertyOffset_TimeLineFX, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TimeLineFX.CopyAssign(value);
			}
		}

		// Token: 0x17007738 RID: 30520
		// (get) Token: 0x0601D95E RID: 121182 RVA: 0x002BAEA0 File Offset: 0x002B90A0
		// (set) Token: 0x0601D95F RID: 121183 RVA: 0x002BAEE3 File Offset: 0x002B90E3
		public TArray<FKSC_Delay_KuroMatFX> TimeLineMatFX
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_Delay_KuroMatFX> result;
				if ((result = this._TimeLineMatFX) == null)
				{
					result = (this._TimeLineMatFX = new TArray<FKSC_Delay_KuroMatFX>(base.NativePtr + (IntPtr)FKSC_TimeLineData.__PropertyOffset_TimeLineMatFX, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TimeLineMatFX.CopyAssign(value);
			}
		}

		// Token: 0x0601D960 RID: 121184 RVA: 0x002BAEF1 File Offset: 0x002B90F1
		public FKSC_TimeLineData()
		{
		}

		// Token: 0x0601D961 RID: 121185 RVA: 0x002BAEF9 File Offset: 0x002B90F9
		public FKSC_TimeLineData(float MaxTime, TArray<FKSC_Delay_KuroFX> TimeLineFX, TArray<FKSC_Delay_KuroMatFX> TimeLineMatFX)
		{
			this.MaxTime = MaxTime;
			this.TimeLineFX = TimeLineFX;
			this.TimeLineMatFX = TimeLineMatFX;
		}

		// Token: 0x0601D962 RID: 121186 RVA: 0x002BAF16 File Offset: 0x002B9116
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_TimeLineData.StaticStruct();
		}

		// Token: 0x0601D963 RID: 121187 RVA: 0x002BAF22 File Offset: 0x002B9122
		[NullableContext(2)]
		public FKSC_TimeLineData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D964 RID: 121188 RVA: 0x002BAF2C File Offset: 0x002B912C
		public FKSC_TimeLineData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D965 RID: 121189 RVA: 0x002BAF37 File Offset: 0x002B9137
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_TimeLineData(Pointer, false, true);
		}

		// Token: 0x0601D966 RID: 121190 RVA: 0x002BAF41 File Offset: 0x002B9141
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_TimeLineData(Pointer, MemoryOwner);
		}

		// Token: 0x04010098 RID: 65688
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_TimeLineData";

		// Token: 0x04010099 RID: 65689
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401009A RID: 65690
		internal static int __PropertyOffset_MaxTime;

		// Token: 0x0401009B RID: 65691
		internal static int __PropertyOffset_TimeLineFX;

		// Token: 0x0401009C RID: 65692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_Delay_KuroFX> _TimeLineFX;

		// Token: 0x0401009D RID: 65693
		internal static int __PropertyOffset_TimeLineMatFX;

		// Token: 0x0401009E RID: 65694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_Delay_KuroMatFX> _TimeLineMatFX;
	}
}
