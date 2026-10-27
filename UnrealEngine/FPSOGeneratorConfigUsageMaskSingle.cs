using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001055 RID: 4181
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigUsageMaskSingle")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FPSOGeneratorConfigUsageMaskSingle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EDD8 RID: 60888 RVA: 0x00161050 File Offset: 0x0015F250
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigUsageMaskSingle._ScriptStructPtr != 0) ? FPSOGeneratorConfigUsageMaskSingle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigUsageMaskSingle", ref FPSOGeneratorConfigUsageMaskSingle._ScriptStructPtr);
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600EDD9 RID: 60889 RVA: 0x00161074 File Offset: 0x0015F274
		// (set) Token: 0x0600EDDA RID: 60890 RVA: 0x00161088 File Offset: 0x0015F288
		public unsafe string MaskName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigUsageMaskSingle.__PropertyOffset_MaskName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigUsageMaskSingle.__PropertyOffset_MaskName)), value);
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600EDDB RID: 60891 RVA: 0x0016109D File Offset: 0x0015F29D
		// (set) Token: 0x0600EDDC RID: 60892 RVA: 0x001610B1 File Offset: 0x0015F2B1
		public unsafe string VariableName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigUsageMaskSingle.__PropertyOffset_VariableName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigUsageMaskSingle.__PropertyOffset_VariableName)), value);
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600EDDD RID: 60893 RVA: 0x001610C6 File Offset: 0x0015F2C6
		// (set) Token: 0x0600EDDE RID: 60894 RVA: 0x001610D6 File Offset: 0x0015F2D6
		public unsafe ulong DefaultMask
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FPSOGeneratorConfigUsageMaskSingle.__PropertyOffset_DefaultMask));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigUsageMaskSingle.__PropertyOffset_DefaultMask) = (long)value;
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600EDDF RID: 60895 RVA: 0x001610E8 File Offset: 0x0015F2E8
		// (set) Token: 0x0600EDE0 RID: 60896 RVA: 0x0016112B File Offset: 0x0015F32B
		public TMap<string, ulong> Switches
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, ulong> result;
				if ((result = this._Switches) == null)
				{
					result = (this._Switches = new TMap<string, ulong>(base.NativePtr + (IntPtr)FPSOGeneratorConfigUsageMaskSingle.__PropertyOffset_Switches, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Switches.CopyAssign(value);
			}
		}

		// Token: 0x0600EDE1 RID: 60897 RVA: 0x00161139 File Offset: 0x0015F339
		public FPSOGeneratorConfigUsageMaskSingle()
		{
		}

		// Token: 0x0600EDE2 RID: 60898 RVA: 0x00161141 File Offset: 0x0015F341
		public FPSOGeneratorConfigUsageMaskSingle(string MaskName, string VariableName, ulong DefaultMask, TMap<string, ulong> Switches)
		{
			this.MaskName = MaskName;
			this.VariableName = VariableName;
			this.DefaultMask = DefaultMask;
			this.Switches = Switches;
		}

		// Token: 0x0600EDE3 RID: 60899 RVA: 0x00161166 File Offset: 0x0015F366
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigUsageMaskSingle.StaticStruct();
		}

		// Token: 0x0600EDE4 RID: 60900 RVA: 0x00161172 File Offset: 0x0015F372
		[NullableContext(2)]
		public FPSOGeneratorConfigUsageMaskSingle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EDE5 RID: 60901 RVA: 0x0016117C File Offset: 0x0015F37C
		public FPSOGeneratorConfigUsageMaskSingle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EDE6 RID: 60902 RVA: 0x00161187 File Offset: 0x0015F387
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigUsageMaskSingle(Pointer, false, true);
		}

		// Token: 0x0600EDE7 RID: 60903 RVA: 0x00161191 File Offset: 0x0015F391
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigUsageMaskSingle(Pointer, MemoryOwner);
		}

		// Token: 0x040080D2 RID: 32978
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigUsageMaskSingle";

		// Token: 0x040080D3 RID: 32979
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080D4 RID: 32980
		internal static int __PropertyOffset_MaskName;

		// Token: 0x040080D5 RID: 32981
		internal static int __PropertyOffset_VariableName;

		// Token: 0x040080D6 RID: 32982
		internal static int __PropertyOffset_DefaultMask;

		// Token: 0x040080D7 RID: 32983
		internal static int __PropertyOffset_Switches;

		// Token: 0x040080D8 RID: 32984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, ulong> _Switches;
	}
}
