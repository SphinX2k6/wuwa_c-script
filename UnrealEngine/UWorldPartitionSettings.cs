using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001282 RID: 4738
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionSettings")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UWorldPartitionSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060115B6 RID: 71094 RVA: 0x00197A12 File Offset: 0x00195C12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionSettings._ClassPtr;
		}

		// Token: 0x060115B7 RID: 71095 RVA: 0x00197A20 File Offset: 0x00195C20
		public UWorldPartitionSettings() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060115B8 RID: 71096 RVA: 0x00197A48 File Offset: 0x00195C48
		public UWorldPartitionSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x060115B9 RID: 71097 RVA: 0x00197A7C File Offset: 0x00195C7C
		// (set) Token: 0x060115BA RID: 71098 RVA: 0x00197AB5 File Offset: 0x00195CB5
		public TMap<string, string> PlatformFilters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._PlatformFilters) == null)
				{
					result = (this._PlatformFilters = new TMap<string, string>(base.NativePtr + (IntPtr)UWorldPartitionSettings.__PropertyOffset_PlatformFilters, this));
				}
				return result;
			}
			set
			{
				this.PlatformFilters.CopyAssign(value);
			}
		}

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x060115BB RID: 71099 RVA: 0x00197AC3 File Offset: 0x00195CC3
		// (set) Token: 0x060115BC RID: 71100 RVA: 0x00197AD3 File Offset: 0x00195CD3
		public unsafe EWorldPartitionDataLayersLogicOperator NewMapsDataLayersLogicOperator
		{
			get
			{
				return (EWorldPartitionDataLayersLogicOperator)(*(base.NativePtr + (IntPtr)UWorldPartitionSettings.__PropertyOffset_NewMapsDataLayersLogicOperator));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionSettings.__PropertyOffset_NewMapsDataLayersLogicOperator) = (byte)value;
			}
		}

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x060115BD RID: 71101 RVA: 0x00197AE4 File Offset: 0x00195CE4
		// (set) Token: 0x060115BE RID: 71102 RVA: 0x00197AF8 File Offset: 0x00195CF8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UWorldPartitionEditorHash> EditorHashDefaultClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionSettings.__PropertyOffset_EditorHashDefaultClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionSettings.__PropertyOffset_EditorHashDefaultClass) = value;
			}
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x060115BF RID: 71103 RVA: 0x00197B0D File Offset: 0x00195D0D
		// (set) Token: 0x060115C0 RID: 71104 RVA: 0x00197B21 File Offset: 0x00195D21
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UWorldPartitionRuntimeHash> RuntimeHashDefaultClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionSettings.__PropertyOffset_RuntimeHashDefaultClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionSettings.__PropertyOffset_RuntimeHashDefaultClass) = value;
			}
		}

		// Token: 0x060115C1 RID: 71105 RVA: 0x00197B36 File Offset: 0x00195D36
		static UWorldPartitionSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionSettings");
		}

		// Token: 0x060115C2 RID: 71106 RVA: 0x00197B44 File Offset: 0x00195D44
		protected UWorldPartitionSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400949D RID: 38045
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionSettings";

		// Token: 0x0400949E RID: 38046
		private static IntPtr _ClassPtr;

		// Token: 0x0400949F RID: 38047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040094A0 RID: 38048
		internal static int __PropertyOffset_PlatformFilters;

		// Token: 0x040094A1 RID: 38049
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _PlatformFilters;

		// Token: 0x040094A2 RID: 38050
		internal static int __PropertyOffset_NewMapsDataLayersLogicOperator;

		// Token: 0x040094A3 RID: 38051
		internal static int __PropertyOffset_EditorHashDefaultClass;

		// Token: 0x040094A4 RID: 38052
		internal static int __PropertyOffset_RuntimeHashDefaultClass;
	}
}
