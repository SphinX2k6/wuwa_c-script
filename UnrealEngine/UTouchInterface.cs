using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011FA RID: 4602
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TouchInterface")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UTouchInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010F83 RID: 69507 RVA: 0x0018E874 File Offset: 0x0018CA74
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTouchInterface._ClassPtr;
		}

		// Token: 0x06010F84 RID: 69508 RVA: 0x0018E880 File Offset: 0x0018CA80
		public UTouchInterface() : this(BuiltinUtils.AllocNativeUObject(UTouchInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010F85 RID: 69509 RVA: 0x0018E8A8 File Offset: 0x0018CAA8
		public UTouchInterface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTouchInterface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x06010F86 RID: 69510 RVA: 0x0018E8DC File Offset: 0x0018CADC
		// (set) Token: 0x06010F87 RID: 69511 RVA: 0x0018E915 File Offset: 0x0018CB15
		public TArray<FTouchInputControl> Controls
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTouchInputControl> result;
				if ((result = this._Controls) == null)
				{
					result = (this._Controls = new TArray<FTouchInputControl>(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_Controls, this));
				}
				return result;
			}
			set
			{
				this.Controls.CopyAssign(value);
			}
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x06010F88 RID: 69512 RVA: 0x0018E923 File Offset: 0x0018CB23
		// (set) Token: 0x06010F89 RID: 69513 RVA: 0x0018E933 File Offset: 0x0018CB33
		public unsafe float ActiveOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_ActiveOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_ActiveOpacity) = value;
			}
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x06010F8A RID: 69514 RVA: 0x0018E944 File Offset: 0x0018CB44
		// (set) Token: 0x06010F8B RID: 69515 RVA: 0x0018E954 File Offset: 0x0018CB54
		public unsafe float InactiveOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_InactiveOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_InactiveOpacity) = value;
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x06010F8C RID: 69516 RVA: 0x0018E965 File Offset: 0x0018CB65
		// (set) Token: 0x06010F8D RID: 69517 RVA: 0x0018E975 File Offset: 0x0018CB75
		public unsafe float TimeUntilDeactive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_TimeUntilDeactive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_TimeUntilDeactive) = value;
			}
		}

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x06010F8E RID: 69518 RVA: 0x0018E986 File Offset: 0x0018CB86
		// (set) Token: 0x06010F8F RID: 69519 RVA: 0x0018E996 File Offset: 0x0018CB96
		public unsafe float TimeUntilReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_TimeUntilReset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_TimeUntilReset) = value;
			}
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x06010F90 RID: 69520 RVA: 0x0018E9A7 File Offset: 0x0018CBA7
		// (set) Token: 0x06010F91 RID: 69521 RVA: 0x0018E9B7 File Offset: 0x0018CBB7
		public unsafe float ActivationDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_ActivationDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_ActivationDelay) = value;
			}
		}

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x06010F92 RID: 69522 RVA: 0x0018E9C8 File Offset: 0x0018CBC8
		// (set) Token: 0x06010F93 RID: 69523 RVA: 0x0018E9D8 File Offset: 0x0018CBD8
		public unsafe bool bPreventRecenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_bPreventRecenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_bPreventRecenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x06010F94 RID: 69524 RVA: 0x0018E9E9 File Offset: 0x0018CBE9
		// (set) Token: 0x06010F95 RID: 69525 RVA: 0x0018E9F9 File Offset: 0x0018CBF9
		public unsafe float StartupDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_StartupDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTouchInterface.__PropertyOffset_StartupDelay) = value;
			}
		}

		// Token: 0x06010F96 RID: 69526 RVA: 0x0018EA0A File Offset: 0x0018CC0A
		static UTouchInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TouchInterface");
		}

		// Token: 0x06010F97 RID: 69527 RVA: 0x0018EA18 File Offset: 0x0018CC18
		protected UTouchInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009169 RID: 37225
		public new const string __ObjectPath = "/Script/Engine.TouchInterface";

		// Token: 0x0400916A RID: 37226
		private static IntPtr _ClassPtr;

		// Token: 0x0400916B RID: 37227
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400916C RID: 37228
		internal static int __PropertyOffset_Controls;

		// Token: 0x0400916D RID: 37229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTouchInputControl> _Controls;

		// Token: 0x0400916E RID: 37230
		internal static int __PropertyOffset_ActiveOpacity;

		// Token: 0x0400916F RID: 37231
		internal static int __PropertyOffset_InactiveOpacity;

		// Token: 0x04009170 RID: 37232
		internal static int __PropertyOffset_TimeUntilDeactive;

		// Token: 0x04009171 RID: 37233
		internal static int __PropertyOffset_TimeUntilReset;

		// Token: 0x04009172 RID: 37234
		internal static int __PropertyOffset_ActivationDelay;

		// Token: 0x04009173 RID: 37235
		internal static int __PropertyOffset_bPreventRecenter;

		// Token: 0x04009174 RID: 37236
		internal static int __PropertyOffset_StartupDelay;
	}
}
