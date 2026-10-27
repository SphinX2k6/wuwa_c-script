using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000988 RID: 2440
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomAttributeSetting")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCustomAttributeSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060089E8 RID: 35304 RVA: 0x000C5903 File Offset: 0x000C3B03
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomAttributeSetting._ScriptStructPtr != 0) ? FCustomAttributeSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomAttributeSetting", ref FCustomAttributeSetting._ScriptStructPtr);
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x000C5927 File Offset: 0x000C3B27
		// (set) Token: 0x060089EA RID: 35306 RVA: 0x000C593B File Offset: 0x000C3B3B
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCustomAttributeSetting.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCustomAttributeSetting.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x060089EB RID: 35307 RVA: 0x000C5950 File Offset: 0x000C3B50
		// (set) Token: 0x060089EC RID: 35308 RVA: 0x000C5964 File Offset: 0x000C3B64
		public unsafe string Meaning
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCustomAttributeSetting.__PropertyOffset_Meaning)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCustomAttributeSetting.__PropertyOffset_Meaning)), value);
			}
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x000C5979 File Offset: 0x000C3B79
		public FCustomAttributeSetting()
		{
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x000C5981 File Offset: 0x000C3B81
		public FCustomAttributeSetting(string Name, string Meaning)
		{
			this.Name = Name;
			this.Meaning = Meaning;
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x000C5997 File Offset: 0x000C3B97
		protected override IntPtr GetUStructPtr()
		{
			return FCustomAttributeSetting.StaticStruct();
		}

		// Token: 0x060089F0 RID: 35312 RVA: 0x000C59A3 File Offset: 0x000C3BA3
		[NullableContext(2)]
		public FCustomAttributeSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x000C59AD File Offset: 0x000C3BAD
		public FCustomAttributeSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x000C59B8 File Offset: 0x000C3BB8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomAttributeSetting(Pointer, false, true);
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x000C59C2 File Offset: 0x000C3BC2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomAttributeSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400417B RID: 16763
		public const string __ObjectPath = "/Script/Engine.CustomAttributeSetting";

		// Token: 0x0400417C RID: 16764
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400417D RID: 16765
		internal static int __PropertyOffset_Name;

		// Token: 0x0400417E RID: 16766
		internal static int __PropertyOffset_Meaning;
	}
}
