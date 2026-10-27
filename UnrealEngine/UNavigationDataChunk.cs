using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000ED7 RID: 3799
	[UnrealObjectPath("/Script/Engine.NavigationDataChunk")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UNavigationDataChunk : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CDC7 RID: 52679 RVA: 0x0012C010 File Offset: 0x0012A210
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationDataChunk._ClassPtr;
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0600CDC8 RID: 52680 RVA: 0x0012C01C File Offset: 0x0012A21C
		// (set) Token: 0x0600CDC9 RID: 52681 RVA: 0x0012C030 File Offset: 0x0012A230
		public unsafe FName NavigationDataName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavigationDataChunk.__PropertyOffset_NavigationDataName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavigationDataChunk.__PropertyOffset_NavigationDataName) = value;
			}
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x0012C045 File Offset: 0x0012A245
		static UNavigationDataChunk()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationDataChunk");
		}

		// Token: 0x0600CDCB RID: 52683 RVA: 0x0012C054 File Offset: 0x0012A254
		protected UNavigationDataChunk() : this(BuiltinUtils.AllocNativeUObject(UNavigationDataChunk.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CDCC RID: 52684 RVA: 0x0012C07C File Offset: 0x0012A27C
		protected UNavigationDataChunk(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006EDD RID: 28381
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationDataChunk";

		// Token: 0x04006EDE RID: 28382
		private static IntPtr _ClassPtr;

		// Token: 0x04006EDF RID: 28383
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006EE0 RID: 28384
		internal static int __PropertyOffset_NavigationDataName;
	}
}
