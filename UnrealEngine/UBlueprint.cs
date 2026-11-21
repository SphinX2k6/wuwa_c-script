using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018D RID: 397
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Blueprint")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class UBlueprint : UBlueprintCore, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019E3 RID: 6627 RVA: 0x00026D96 File Offset: 0x00024F96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprint._ClassPtr;
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00026DA4 File Offset: 0x00024FA4
		public UBlueprint() : this(BuiltinUtils.AllocNativeUObject(UBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00026DCC File Offset: 0x00024FCC
		public UBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00026DFF File Offset: 0x00024FFF
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x00026E13 File Offset: 0x00025013
		public unsafe UClassStackOnlyPtr ParentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_ParentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_ParentClass) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00026E28 File Offset: 0x00025028
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00026E41 File Offset: 0x00025041
		public unsafe bool bRecompileOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bRecompileOnLoad) & UBlueprint.__PropertyMask_bRecompileOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bRecompileOnLoad) = ((*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bRecompileOnLoad) & ~UBlueprint.__PropertyMask_bRecompileOnLoad) | (value ? UBlueprint.__PropertyMask_bRecompileOnLoad : 0));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00026E71 File Offset: 0x00025071
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00026E8A File Offset: 0x0002508A
		public unsafe bool bHasBeenRegenerated
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bHasBeenRegenerated) & UBlueprint.__PropertyMask_bHasBeenRegenerated) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bHasBeenRegenerated) = ((*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bHasBeenRegenerated) & ~UBlueprint.__PropertyMask_bHasBeenRegenerated) | (value ? UBlueprint.__PropertyMask_bHasBeenRegenerated : 0));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00026EBA File Offset: 0x000250BA
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x00026ED3 File Offset: 0x000250D3
		public unsafe bool bIsRegeneratingOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bIsRegeneratingOnLoad) & UBlueprint.__PropertyMask_bIsRegeneratingOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bIsRegeneratingOnLoad) = ((*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_bIsRegeneratingOnLoad) & ~UBlueprint.__PropertyMask_bIsRegeneratingOnLoad) | (value ? UBlueprint.__PropertyMask_bIsRegeneratingOnLoad : 0));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00026F03 File Offset: 0x00025103
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x00026F13 File Offset: 0x00025113
		public unsafe int BlueprintSystemVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_BlueprintSystemVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_BlueprintSystemVersion) = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00026F24 File Offset: 0x00025124
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00026F5D File Offset: 0x0002515D
		public TArray<UActorComponent> ComponentTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ComponentTemplates) == null)
				{
					result = (this._ComponentTemplates = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UBlueprint.__PropertyOffset_ComponentTemplates, this));
				}
				return result;
			}
			set
			{
				this.ComponentTemplates.CopyAssign(value);
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00026F6B File Offset: 0x0002516B
		static UBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Blueprint");
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00026F79 File Offset: 0x00025179
		protected UBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000849 RID: 2121
		public new const string __ObjectPath = "/Script/Engine.Blueprint";

		// Token: 0x0400084A RID: 2122
		private static IntPtr _ClassPtr;

		// Token: 0x0400084B RID: 2123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400084C RID: 2124
		internal static int __PropertyOffset_ParentClass;

		// Token: 0x0400084D RID: 2125
		internal static int __PropertyOffset_bRecompileOnLoad;

		// Token: 0x0400084E RID: 2126
		internal static byte __PropertyMask_bRecompileOnLoad;

		// Token: 0x0400084F RID: 2127
		internal static int __PropertyOffset_bHasBeenRegenerated;

		// Token: 0x04000850 RID: 2128
		internal static byte __PropertyMask_bHasBeenRegenerated;

		// Token: 0x04000851 RID: 2129
		internal static int __PropertyOffset_bIsRegeneratingOnLoad;

		// Token: 0x04000852 RID: 2130
		internal static byte __PropertyMask_bIsRegeneratingOnLoad;

		// Token: 0x04000853 RID: 2131
		internal static int __PropertyOffset_BlueprintSystemVersion;

		// Token: 0x04000854 RID: 2132
		internal static int __PropertyOffset_ComponentTemplates;

		// Token: 0x04000855 RID: 2133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentTemplates;
	}
}
