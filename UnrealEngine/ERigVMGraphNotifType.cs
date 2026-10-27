using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026B2 RID: 9906
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RigVMDeveloper.ERigVMGraphNotifType")]
	public enum ERigVMGraphNotifType : byte
	{
		// Token: 0x04013CDF RID: 81119
		GraphChanged,
		// Token: 0x04013CE0 RID: 81120
		NodeAdded,
		// Token: 0x04013CE1 RID: 81121
		NodeRemoved,
		// Token: 0x04013CE2 RID: 81122
		NodeSelected,
		// Token: 0x04013CE3 RID: 81123
		NodeDeselected,
		// Token: 0x04013CE4 RID: 81124
		NodeSelectionChanged,
		// Token: 0x04013CE5 RID: 81125
		NodePositionChanged,
		// Token: 0x04013CE6 RID: 81126
		NodeSizeChanged,
		// Token: 0x04013CE7 RID: 81127
		NodeColorChanged,
		// Token: 0x04013CE8 RID: 81128
		PinExpansionChanged,
		// Token: 0x04013CE9 RID: 81129
		PinWatchedChanged,
		// Token: 0x04013CEA RID: 81130
		PinArraySizeChanged,
		// Token: 0x04013CEB RID: 81131
		PinDefaultValueChanged,
		// Token: 0x04013CEC RID: 81132
		PinDirectionChanged,
		// Token: 0x04013CED RID: 81133
		PinTypeChanged,
		// Token: 0x04013CEE RID: 81134
		LinkAdded,
		// Token: 0x04013CEF RID: 81135
		LinkRemoved,
		// Token: 0x04013CF0 RID: 81136
		CommentTextChanged,
		// Token: 0x04013CF1 RID: 81137
		RerouteCompactnessChanged,
		// Token: 0x04013CF2 RID: 81138
		VariableAdded,
		// Token: 0x04013CF3 RID: 81139
		VariableRemoved,
		// Token: 0x04013CF4 RID: 81140
		VariableRenamed,
		// Token: 0x04013CF5 RID: 81141
		ParameterAdded,
		// Token: 0x04013CF6 RID: 81142
		ParameterRemoved,
		// Token: 0x04013CF7 RID: 81143
		ParameterRenamed,
		// Token: 0x04013CF8 RID: 81144
		InteractionBracketOpened,
		// Token: 0x04013CF9 RID: 81145
		InteractionBracketClosed,
		// Token: 0x04013CFA RID: 81146
		InteractionBracketCanceled,
		// Token: 0x04013CFB RID: 81147
		Invalid,
		// Token: 0x04013CFC RID: 81148
		ERigVMGraphNotifType_MAX
	}
}
