using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200264D RID: 9805
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PortalServices.PortalUserDetails")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FPortalUserDetails : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060246EB RID: 149227 RVA: 0x0035EE12 File Offset: 0x0035D012
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPortalUserDetails._ScriptStructPtr != 0) ? FPortalUserDetails._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PortalServices.PortalUserDetails", ref FPortalUserDetails._ScriptStructPtr);
		}

		// Token: 0x17008C67 RID: 35943
		// (get) Token: 0x060246EC RID: 149228 RVA: 0x0035EE38 File Offset: 0x0035D038
		// (set) Token: 0x060246ED RID: 149229 RVA: 0x0035EE7B File Offset: 0x0035D07B
		public unsafe FText DisplayName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DisplayName) == null)
				{
					result = (this._DisplayName = new FText(base.NativePtr + (IntPtr)FPortalUserDetails.__PropertyOffset_DisplayName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FPortalUserDetails.__PropertyOffset_DisplayName)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008C68 RID: 35944
		// (get) Token: 0x060246EE RID: 149230 RVA: 0x0035EE98 File Offset: 0x0035D098
		// (set) Token: 0x060246EF RID: 149231 RVA: 0x0035EEDB File Offset: 0x0035D0DB
		public unsafe FText Email
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Email) == null)
				{
					result = (this._Email = new FText(base.NativePtr + (IntPtr)FPortalUserDetails.__PropertyOffset_Email, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FPortalUserDetails.__PropertyOffset_Email)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008C69 RID: 35945
		// (get) Token: 0x060246F0 RID: 149232 RVA: 0x0035EEF8 File Offset: 0x0035D0F8
		// (set) Token: 0x060246F1 RID: 149233 RVA: 0x0035EF3B File Offset: 0x0035D13B
		public unsafe FText RealName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._RealName) == null)
				{
					result = (this._RealName = new FText(base.NativePtr + (IntPtr)FPortalUserDetails.__PropertyOffset_RealName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FPortalUserDetails.__PropertyOffset_RealName)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008C6A RID: 35946
		// (get) Token: 0x060246F2 RID: 149234 RVA: 0x0035EF56 File Offset: 0x0035D156
		// (set) Token: 0x060246F3 RID: 149235 RVA: 0x0035EF66 File Offset: 0x0035D166
		public unsafe bool IsSignedIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPortalUserDetails.__PropertyOffset_IsSignedIn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPortalUserDetails.__PropertyOffset_IsSignedIn) = (value ? 1 : 0);
			}
		}

		// Token: 0x060246F4 RID: 149236 RVA: 0x0035EF77 File Offset: 0x0035D177
		public FPortalUserDetails()
		{
		}

		// Token: 0x060246F5 RID: 149237 RVA: 0x0035EF7F File Offset: 0x0035D17F
		public FPortalUserDetails(FText DisplayName, FText Email, FText RealName, bool IsSignedIn)
		{
			this.DisplayName = DisplayName;
			this.Email = Email;
			this.RealName = RealName;
			this.IsSignedIn = IsSignedIn;
		}

		// Token: 0x060246F6 RID: 149238 RVA: 0x0035EFA4 File Offset: 0x0035D1A4
		protected override IntPtr GetUStructPtr()
		{
			return FPortalUserDetails.StaticStruct();
		}

		// Token: 0x060246F7 RID: 149239 RVA: 0x0035EFB0 File Offset: 0x0035D1B0
		[NullableContext(2)]
		public FPortalUserDetails(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060246F8 RID: 149240 RVA: 0x0035EFBA File Offset: 0x0035D1BA
		public FPortalUserDetails(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060246F9 RID: 149241 RVA: 0x0035EFC5 File Offset: 0x0035D1C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPortalUserDetails(Pointer, false, true);
		}

		// Token: 0x060246FA RID: 149242 RVA: 0x0035EFCF File Offset: 0x0035D1CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPortalUserDetails(Pointer, MemoryOwner);
		}

		// Token: 0x04013928 RID: 80168
		public const string __ObjectPath = "/Script/PortalServices.PortalUserDetails";

		// Token: 0x04013929 RID: 80169
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401392A RID: 80170
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x0401392B RID: 80171
		[Nullable(2)]
		private FText _DisplayName;

		// Token: 0x0401392C RID: 80172
		internal static int __PropertyOffset_Email;

		// Token: 0x0401392D RID: 80173
		[Nullable(2)]
		private FText _Email;

		// Token: 0x0401392E RID: 80174
		internal static int __PropertyOffset_RealName;

		// Token: 0x0401392F RID: 80175
		[Nullable(2)]
		private FText _RealName;

		// Token: 0x04013930 RID: 80176
		internal static int __PropertyOffset_IsSignedIn;
	}
}
