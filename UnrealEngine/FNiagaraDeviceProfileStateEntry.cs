using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002597 RID: 9623
	[UnrealObjectPath("/Script/Niagara.NiagaraDeviceProfileStateEntry")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FNiagaraDeviceProfileStateEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023BA0 RID: 146336 RVA: 0x0034D2E3 File Offset: 0x0034B4E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDeviceProfileStateEntry._ScriptStructPtr != 0) ? FNiagaraDeviceProfileStateEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDeviceProfileStateEntry", ref FNiagaraDeviceProfileStateEntry._ScriptStructPtr);
		}

		// Token: 0x1700893C RID: 35132
		// (get) Token: 0x06023BA1 RID: 146337 RVA: 0x0034D307 File Offset: 0x0034B507
		// (set) Token: 0x06023BA2 RID: 146338 RVA: 0x0034D31B File Offset: 0x0034B51B
		public unsafe FName ProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDeviceProfileStateEntry.__PropertyOffset_ProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDeviceProfileStateEntry.__PropertyOffset_ProfileName) = value;
			}
		}

		// Token: 0x1700893D RID: 35133
		// (get) Token: 0x06023BA3 RID: 146339 RVA: 0x0034D330 File Offset: 0x0034B530
		// (set) Token: 0x06023BA4 RID: 146340 RVA: 0x0034D340 File Offset: 0x0034B540
		public unsafe uint QualityLevelMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDeviceProfileStateEntry.__PropertyOffset_QualityLevelMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDeviceProfileStateEntry.__PropertyOffset_QualityLevelMask) = (int)value;
			}
		}

		// Token: 0x1700893E RID: 35134
		// (get) Token: 0x06023BA5 RID: 146341 RVA: 0x0034D351 File Offset: 0x0034B551
		// (set) Token: 0x06023BA6 RID: 146342 RVA: 0x0034D361 File Offset: 0x0034B561
		public unsafe uint SetQualityLevelMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDeviceProfileStateEntry.__PropertyOffset_SetQualityLevelMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDeviceProfileStateEntry.__PropertyOffset_SetQualityLevelMask) = (int)value;
			}
		}

		// Token: 0x06023BA7 RID: 146343 RVA: 0x0034D372 File Offset: 0x0034B572
		public FNiagaraDeviceProfileStateEntry()
		{
		}

		// Token: 0x06023BA8 RID: 146344 RVA: 0x0034D37A File Offset: 0x0034B57A
		public FNiagaraDeviceProfileStateEntry(FName ProfileName, uint QualityLevelMask, uint SetQualityLevelMask)
		{
			this.ProfileName = ProfileName;
			this.QualityLevelMask = QualityLevelMask;
			this.SetQualityLevelMask = SetQualityLevelMask;
		}

		// Token: 0x06023BA9 RID: 146345 RVA: 0x0034D397 File Offset: 0x0034B597
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDeviceProfileStateEntry.StaticStruct();
		}

		// Token: 0x06023BAA RID: 146346 RVA: 0x0034D3A3 File Offset: 0x0034B5A3
		[NullableContext(2)]
		public FNiagaraDeviceProfileStateEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023BAB RID: 146347 RVA: 0x0034D3AD File Offset: 0x0034B5AD
		public FNiagaraDeviceProfileStateEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023BAC RID: 146348 RVA: 0x0034D3B8 File Offset: 0x0034B5B8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDeviceProfileStateEntry(Pointer, false, true);
		}

		// Token: 0x06023BAD RID: 146349 RVA: 0x0034D3C2 File Offset: 0x0034B5C2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDeviceProfileStateEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04013284 RID: 78468
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraDeviceProfileStateEntry";

		// Token: 0x04013285 RID: 78469
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013286 RID: 78470
		internal static int __PropertyOffset_ProfileName;

		// Token: 0x04013287 RID: 78471
		internal static int __PropertyOffset_QualityLevelMask;

		// Token: 0x04013288 RID: 78472
		internal static int __PropertyOffset_SetQualityLevelMask;
	}
}
