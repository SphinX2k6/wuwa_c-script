using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200287E RID: 10366
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMBlueprintGeneratedClass")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class USMBlueprintGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060265F0 RID: 157168 RVA: 0x003A4F57 File Offset: 0x003A3157
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMBlueprintGeneratedClass._ClassPtr;
		}

		// Token: 0x060265F1 RID: 157169 RVA: 0x003A4F64 File Offset: 0x003A3164
		public USMBlueprintGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(USMBlueprintGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060265F2 RID: 157170 RVA: 0x003A4F8C File Offset: 0x003A318C
		public USMBlueprintGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMBlueprintGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093FE RID: 37886
		// (get) Token: 0x060265F3 RID: 157171 RVA: 0x003A4FBF File Offset: 0x003A31BF
		// (set) Token: 0x060265F4 RID: 157172 RVA: 0x003A4FD3 File Offset: 0x003A31D3
		public unsafe FGuid RootGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMBlueprintGeneratedClass.__PropertyOffset_RootGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMBlueprintGeneratedClass.__PropertyOffset_RootGuid) = value;
			}
		}

		// Token: 0x170093FF RID: 37887
		// (get) Token: 0x060265F5 RID: 157173 RVA: 0x003A4FE8 File Offset: 0x003A31E8
		// (set) Token: 0x060265F6 RID: 157174 RVA: 0x003A5021 File Offset: 0x003A3221
		public TArray<USMStateMachineInstance> AllRootInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USMStateMachineInstance> result;
				if ((result = this._AllRootInstances) == null)
				{
					result = (this._AllRootInstances = new TArray<USMStateMachineInstance>(base.NativePtr + (IntPtr)USMBlueprintGeneratedClass.__PropertyOffset_AllRootInstances, this));
				}
				return result;
			}
			set
			{
				this.AllRootInstances.CopyAssign(value);
			}
		}

		// Token: 0x060265F7 RID: 157175 RVA: 0x003A502F File Offset: 0x003A322F
		static USMBlueprintGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMBlueprintGeneratedClass");
		}

		// Token: 0x060265F8 RID: 157176 RVA: 0x003A503D File Offset: 0x003A323D
		protected USMBlueprintGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040150B3 RID: 86195
		public new const string __ObjectPath = "/Script/SMSystem.SMBlueprintGeneratedClass";

		// Token: 0x040150B4 RID: 86196
		private static IntPtr _ClassPtr;

		// Token: 0x040150B5 RID: 86197
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040150B6 RID: 86198
		internal static int __PropertyOffset_RootGuid;

		// Token: 0x040150B7 RID: 86199
		internal static int __PropertyOffset_AllRootInstances;

		// Token: 0x040150B8 RID: 86200
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USMStateMachineInstance> _AllRootInstances;
	}
}
