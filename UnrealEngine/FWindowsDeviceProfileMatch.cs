using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A67 RID: 10855
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatch")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FWindowsDeviceProfileMatch : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280E0 RID: 164064 RVA: 0x003CF9F5 File Offset: 0x003CDBF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWindowsDeviceProfileMatch._ScriptStructPtr != 0) ? FWindowsDeviceProfileMatch._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatch", ref FWindowsDeviceProfileMatch._ScriptStructPtr);
		}

		// Token: 0x170098F4 RID: 39156
		// (get) Token: 0x060280E1 RID: 164065 RVA: 0x003CFA19 File Offset: 0x003CDC19
		// (set) Token: 0x060280E2 RID: 164066 RVA: 0x003CFA2D File Offset: 0x003CDC2D
		public unsafe string Profile
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWindowsDeviceProfileMatch.__PropertyOffset_Profile)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWindowsDeviceProfileMatch.__PropertyOffset_Profile)), value);
			}
		}

		// Token: 0x170098F5 RID: 39157
		// (get) Token: 0x060280E3 RID: 164067 RVA: 0x003CFA44 File Offset: 0x003CDC44
		// (set) Token: 0x060280E4 RID: 164068 RVA: 0x003CFA87 File Offset: 0x003CDC87
		public TArray<FWindowsDeviceProfileMatchItem> Match
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWindowsDeviceProfileMatchItem> result;
				if ((result = this._Match) == null)
				{
					result = (this._Match = new TArray<FWindowsDeviceProfileMatchItem>(base.NativePtr + (IntPtr)FWindowsDeviceProfileMatch.__PropertyOffset_Match, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Match.CopyAssign(value);
			}
		}

		// Token: 0x060280E5 RID: 164069 RVA: 0x003CFA95 File Offset: 0x003CDC95
		public FWindowsDeviceProfileMatch()
		{
		}

		// Token: 0x060280E6 RID: 164070 RVA: 0x003CFA9D File Offset: 0x003CDC9D
		public FWindowsDeviceProfileMatch(string Profile, TArray<FWindowsDeviceProfileMatchItem> Match)
		{
			this.Profile = Profile;
			this.Match = Match;
		}

		// Token: 0x060280E7 RID: 164071 RVA: 0x003CFAB3 File Offset: 0x003CDCB3
		protected override IntPtr GetUStructPtr()
		{
			return FWindowsDeviceProfileMatch.StaticStruct();
		}

		// Token: 0x060280E8 RID: 164072 RVA: 0x003CFABF File Offset: 0x003CDCBF
		[NullableContext(2)]
		public FWindowsDeviceProfileMatch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280E9 RID: 164073 RVA: 0x003CFAC9 File Offset: 0x003CDCC9
		public FWindowsDeviceProfileMatch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280EA RID: 164074 RVA: 0x003CFAD4 File Offset: 0x003CDCD4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWindowsDeviceProfileMatch(Pointer, false, true);
		}

		// Token: 0x060280EB RID: 164075 RVA: 0x003CFADE File Offset: 0x003CDCDE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWindowsDeviceProfileMatch(Pointer, MemoryOwner);
		}

		// Token: 0x04015FA4 RID: 90020
		public const string __ObjectPath = "/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatch";

		// Token: 0x04015FA5 RID: 90021
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015FA6 RID: 90022
		internal static int __PropertyOffset_Profile;

		// Token: 0x04015FA7 RID: 90023
		internal static int __PropertyOffset_Match;

		// Token: 0x04015FA8 RID: 90024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWindowsDeviceProfileMatchItem> _Match;
	}
}
