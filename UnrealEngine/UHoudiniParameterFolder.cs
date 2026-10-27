using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014EF RID: 5359
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterFolder")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UHoudiniParameterFolder : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060136B8 RID: 79544 RVA: 0x001C8D66 File Offset: 0x001C6F66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterFolder._ClassPtr;
		}

		// Token: 0x060136B9 RID: 79545 RVA: 0x001C8D74 File Offset: 0x001C6F74
		public UHoudiniParameterFolder() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060136BA RID: 79546 RVA: 0x001C8D9C File Offset: 0x001C6F9C
		[NullableContext(1)]
		public UHoudiniParameterFolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x060136BB RID: 79547 RVA: 0x001C8DCF File Offset: 0x001C6FCF
		// (set) Token: 0x060136BC RID: 79548 RVA: 0x001C8DDF File Offset: 0x001C6FDF
		public unsafe EHoudiniFolderParameterType FolderType
		{
			get
			{
				return (EHoudiniFolderParameterType)(*(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_FolderType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_FolderType) = (byte)value;
			}
		}

		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x060136BD RID: 79549 RVA: 0x001C8DF0 File Offset: 0x001C6FF0
		// (set) Token: 0x060136BE RID: 79550 RVA: 0x001C8E00 File Offset: 0x001C7000
		public unsafe bool bExpanded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_bExpanded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_bExpanded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x060136BF RID: 79551 RVA: 0x001C8E11 File Offset: 0x001C7011
		// (set) Token: 0x060136C0 RID: 79552 RVA: 0x001C8E21 File Offset: 0x001C7021
		public unsafe bool bChosen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_bChosen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_bChosen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x060136C1 RID: 79553 RVA: 0x001C8E32 File Offset: 0x001C7032
		// (set) Token: 0x060136C2 RID: 79554 RVA: 0x001C8E42 File Offset: 0x001C7042
		public unsafe int ChildCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_ChildCounter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_ChildCounter) = value;
			}
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x060136C3 RID: 79555 RVA: 0x001C8E53 File Offset: 0x001C7053
		// (set) Token: 0x060136C4 RID: 79556 RVA: 0x001C8E63 File Offset: 0x001C7063
		public unsafe bool bIsContentShown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_bIsContentShown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFolder.__PropertyOffset_bIsContentShown) = (value ? 1 : 0);
			}
		}

		// Token: 0x060136C5 RID: 79557 RVA: 0x001C8E74 File Offset: 0x001C7074
		static UHoudiniParameterFolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterFolder");
		}

		// Token: 0x060136C6 RID: 79558 RVA: 0x001C8E82 File Offset: 0x001C7082
		protected UHoudiniParameterFolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7E7 RID: 42983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterFolder";

		// Token: 0x0400A7E8 RID: 42984
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7E9 RID: 42985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7EA RID: 42986
		internal static int __PropertyOffset_FolderType;

		// Token: 0x0400A7EB RID: 42987
		internal static int __PropertyOffset_bExpanded;

		// Token: 0x0400A7EC RID: 42988
		internal static int __PropertyOffset_bChosen;

		// Token: 0x0400A7ED RID: 42989
		internal static int __PropertyOffset_ChildCounter;

		// Token: 0x0400A7EE RID: 42990
		internal static int __PropertyOffset_bIsContentShown;
	}
}
